﻿using Newtonsoft.Json;
using System;
using TootNet.Internal;

namespace TootNet.Objects
{
    public class Marker : BaseObject
    {
        [JsonProperty("last_read_id")]
        public string LastReadId { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
