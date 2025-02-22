﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TootNet.Internal;

namespace TootNet.Objects
{
    public class Poll : BaseObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("expires_at")]
        public DateTime? ExpiresAt { get; set; }

        [JsonProperty("expired")]
        public bool Expired { get; set; }

        [JsonProperty("multiple")]
        public bool Multiple { get; set; }

        [JsonProperty("votes_count")]
        public int VotesCount { get; set; }

        [JsonProperty("voters_count")]
        public int? VotersCount { get; set; }

        [JsonProperty("options")]
        public IEnumerable<PollOption> Options { get; set; }

        [JsonProperty("emojis")]
        public IEnumerable<CustomEmoji> Emojis { get; set; }

        [JsonProperty("voted")]
        public bool? Voted { get; set; }

        [JsonProperty("own_votes")]
        public IEnumerable<int> OwnVotes { get; set; }
    }

    public class PollOption
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("votes_count")]
        public int? VotesCount { get; set; }
    }
}
