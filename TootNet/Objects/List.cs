using Newtonsoft.Json;
using TootNet.Internal;

namespace TootNet.Objects
{
    public class List : BaseObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("replies_policy")]
        public string RepliesPolicy { get; set; }
    }
}
