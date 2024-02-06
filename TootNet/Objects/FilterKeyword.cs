using Newtonsoft.Json;
using TootNet.Internal;


namespace TootNet.Objects
{
    public class FilterKeyword : BaseObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        [JsonProperty("whole_word")]
        public bool WholeWord { get; set; }
    }
}
