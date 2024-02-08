using Newtonsoft.Json;
using System.Collections.Generic;

namespace TootNet.Objects
{
    public class EmojiReaction : BaseObject
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("me")]
        public bool Me { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }


        [JsonProperty("account_ids")]
        public IEnumerable<string> AccountIds { get; set; }
    }
}
