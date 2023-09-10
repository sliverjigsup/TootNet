import glob
import json
import logging
import os

HEADER = """
// Generated by TootNet.Generator.  DO NOT EDIT!

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TootNet.Internal;
using TootNet.Objects;

namespace TootNet.Rest
{{
    public class {class_name} : ApiBase
    {{
        internal {class_name}(Tokens e) : base(e) {{ }}
""".strip(
    "\n"
)

EXPR_FUNC = """
        public Task{return_type} {method_name}Async(params Expression<Func<string, object>>[] parameters)
        {{
            return Tokens.Access{parameter_reserved}ApiAsync{return_type}(MethodType.{method_type}, "{route}"{reserved}, Utils.ExpressionToDictionary(parameters){api_version});
        }}
""".strip(
    "\n"
)

DIC_FUNC = """
        public Task{return_type} {method_name}Async(IDictionary<string, object> parameters)
        {{
            return Tokens.Access{parameter_reserved}ApiAsync{return_type}(MethodType.{method_type}, "{route}"{reserved}, parameters{api_version});
        }}
""".strip(
    "\n"
)

FOOTER = """
    }}
}}
""".strip(
    "\n"
)

INDENT = "        "

TEMPLATE_TYPE_TO_CSHARP_TYPE = {
    "Number": "int",
    "Integer": "int",
    "UInteger": "uint",
    "Long": "long",
    "ULong": "ulong",
    "Float": "float",
    "Double": "double",
    "Char": "char",
    "Boolean": "bool",
    "String": "string",
}

LONG_TYPE_PARAMS = [
    "id",
    "max_id",
    "since_id",
    "min_id",
    "account_id",
    "account_ids",
    "status_id",
    "status_ids",
    "list_id",
    "list_ids",
    "media_id",
    "media_ids",
    "in_reply_to_id",
    "home[last_read_id]",
    "notifications[last_read_id]",
]


def snake_to_pascal(text):
    return "".join(word.capitalize() for word in text.split("_"))


def write_cs_code(input_path: str, output_path: str, logger: logging.Logger) -> None:
    name = os.path.basename(input_path).replace(".json", "")

    class_name = snake_to_pascal(name)
    if class_name == "Oembed":
        class_name = "OEmbed"

    with open(input_path) as fin, open(output_path, "w") as fout:
        fout.write(HEADER.format(class_name=class_name).lstrip() + "\n")

        for method in json.load(fin):
            fout.write("\n")

            # write documents
            fout.write(f"{INDENT}/// <summary>\n")
            fout.write(f"{INDENT}/// <para>{method['description']}</para>\n")
            fout.write(f"{INDENT}/// <para>Available parameters:</para>\n")
            if len(method["parameters"]) == 0:
                fout.write(f"{INDENT}/// <para>- No parameters available in this method.</para>\n")
            else:
                for parameter in method["parameters"]:
                    ptype = parameter["type"]
                    ptypeenu = False
                    if ptype.startswith("Array "):
                        ptype = ptype.replace("Array ", "")
                        ptypeenu = True
                    if ptype in TEMPLATE_TYPE_TO_CSHARP_TYPE:
                        ptype = TEMPLATE_TYPE_TO_CSHARP_TYPE[ptype]
                    else:
                        ptype = ptype.lower()
                    pname = parameter["name"].replace(":", "")
                    popt = "required" if parameter["required"] else "optional"
                    if pname in LONG_TYPE_PARAMS:
                        ptype = "long"
                    if ptypeenu:
                        ptype = f"IEnumerable&lt;{ptype}&gt;"
                    pnote = f" ({parameter['note']})" if "note" in parameter else ""

                    fout.write(f"{INDENT}/// <para>- <c>{ptype}</c> {pname}{pnote} ({popt})</para>\n")
            fout.write(f"{INDENT}/// </summary>\n")

            fout.write(f'{INDENT}/// <param name="parameters">The parameters.</param>\n')

            fout.write(f"{INDENT}/// <returns>\n")
            retd: str
            if method["return"].startswith("Array "):
                retd = "list of " + method["return"].replace("Array ", "").lower()
            else:
                retd = method["return"].lower()
            fout.write(f"{INDENT}/// <para>The task object representing the asynchronous operation.</para>\n")
            fout.write(f"{INDENT}/// <para>The Result property on the task object returns the {retd} object.</para>\n")
            fout.write(f"{INDENT}/// </returns>\n")

            # extract method info
            if method["return"].split(" ")[-1] in TEMPLATE_TYPE_TO_CSHARP_TYPE.values():
                return_type = method["return"].split(" ")[-1].lower()
            elif method["return"].split(" ")[-1] == "Empty":
                return_type = ""
            elif method["return"].startswith("Dict "):
                return_type = "IDictionary<" + ", ".join(method["return"].split(" ")[-1].lower().split(",")) + ">"
            else:
                return_type = "Objects." + method["return"].split(" ")[-1]

            if method["return"].startswith("Array "):
                if any(["since_id" == x["name"] for x in method["parameters"]]):
                    return_type = "Linked<" + return_type + ">"
                else:
                    return_type = "IEnumerable<" + return_type + ">"

            if return_type:
                return_type = "<" + return_type + ">"

            method_type = snake_to_pascal(method["method"])

            if ":" in method["path"].split("/")[-1]:
                if method_type == "Get" and method["path"].split("/")[-1] == ":id":
                    method_name = snake_to_pascal(method["path"].split("/")[-1].replace(":", ""))
                else:
                    method_name = snake_to_pascal(method["path"].split("/")[-2])
            else:
                method_name = snake_to_pascal(method["path"].split("/")[-1])
            if method_name.lower() == class_name.lower():
                method_name = snake_to_pascal(method["method"])

            if "name" in method:
                method_name = method["name"]

            route = method["path"].replace("/api/v1/", "")
            api_version = ""
            if "/api/v2/" in method["path"]:
                route = method["path"].replace("/api/v2/", "")
                api_version = ', apiVersion: "v2"'
            route = "/".join(["{" + x.replace(":", "") + "}" if x.startswith(":") else x for x in route.split("/")])

            reserved = ""
            if ":" in method["path"]:
                res_params = [x["name"].replace(":", "") for x in method["parameters"] if x["name"].startswith(":")]
                if len(res_params) == 1:
                    reserved = f', "{res_params[0]}"'
                else:
                    reserved = ", ".join([f'"{x}"' for x in res_params])
                    reserved = f', new []{{{reserved}}}'

            parameter_reserved = "ParameterReserved" if ":" in method["path"] else ""

            # write expr method
            fout.write(
                EXPR_FUNC.format(
                    return_type=return_type,
                    method_name=method_name,
                    method_type=method_type,
                    route=route,
                    api_version=api_version,
                    reserved=reserved,
                    parameter_reserved=parameter_reserved,
                )
            )
            fout.write("\n\n")

            # write inheritdoc
            fout.write(f'{INDENT}/// <inheritdoc cref="{method_name}Async(Expression{{Func{{string, object}}}}[])"/>')
            fout.write("\n")

            # write dic method
            fout.write(
                DIC_FUNC.format(
                    return_type=return_type,
                    method_name=method_name,
                    method_type=method_type,
                    route=route,
                    api_version=api_version,
                    reserved=reserved,
                    parameter_reserved=parameter_reserved,
                )
            )
            fout.write("\n")

        print(FOOTER.format(), file=fout)


def main(template_dir: str, output_dir: str, logger: logging.Logger) -> None:
    logger.info("generate template from mastodon documentation")
    for input_path in sorted(glob.glob(os.path.join(template_dir, "*.json"))):
        name = os.path.basename(input_path).replace(".json", "")

        output_path = os.path.join(output_dir, f"{snake_to_pascal(name)}.cs")

        write_cs_code(input_path, output_path, logger)

    logger.info("complete!")
