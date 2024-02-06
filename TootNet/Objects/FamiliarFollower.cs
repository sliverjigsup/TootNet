using Newtonsoft.Json;
using System.Collections.Generic;
using TootNet.Internal;

namespace TootNet.Objects
{
    public class FamiliarFollower : BaseObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("accounts")]
        public IEnumerable<Account> Accounts { get; set; }
    }
}
