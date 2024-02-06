using Newtonsoft.Json;
using TootNet.Internal;


namespace TootNet.Objects
{
    public class FilterStatus : BaseObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status_id")]
        public string StatusId { get; set; }
    }
}
