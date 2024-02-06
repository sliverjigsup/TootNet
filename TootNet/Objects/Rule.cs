using Newtonsoft.Json;
using TootNet.Internal;

namespace TootNet.Objects
{
    public class Rule : BaseObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }


        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
