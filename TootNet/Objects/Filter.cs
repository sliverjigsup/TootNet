﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TootNet.Internal;


namespace TootNet.Objects
{
    public class Filter : BaseObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("context")]
        public IEnumerable<string> Context { get; set; }

        [JsonProperty("expires_at")]
        public DateTime? ExpiresAt { get; set; }

        [JsonProperty("filter_action")]
        public string FilterAction { get; set; }

        [JsonProperty("keywords")]
        public IEnumerable<FilterKeyword> Keywords { get; set; }

        [JsonProperty("statuses")]
        public IEnumerable<FilterStatus> Statuses { get; set; }
    }
}
