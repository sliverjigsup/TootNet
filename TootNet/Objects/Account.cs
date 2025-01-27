﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TootNet.Internal;

namespace TootNet.Objects
{
    public class Account : BaseObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("acct")]
        public string Acct { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("avatar_static")]
        public string AvatarStatic { get; set; }

        [JsonProperty("header")]
        public string Header { get; set; }

        [JsonProperty("header_static")]
        public string HeaderStatic { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("fields")]
        public IEnumerable<AccountField> Fields { get; set; }

        [JsonProperty("emojis")]
        public IEnumerable<CustomEmoji> Emojis { get; set; }

        [JsonProperty("bot")]
        public bool Bot { get; set; }

        [JsonProperty("group")]
        public bool Group { get; set; }

        [JsonProperty("discoverable")]
        public bool? Discoverable { get; set; }

        [JsonProperty("noindex")]
        public bool? Noindex { get; set; }

        [JsonProperty("moved")]
        public Account Moved { get; set; }

        [JsonProperty("suspended")]
        public bool? Suspended { get; set; }

        [JsonProperty("limited")]
        public bool? Limited { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("last_status_at")]
        public DateTime? LastStatusAt { get; set; }

        [JsonProperty("statuses_count")]
        public int StatusesCount { get; set; }

        [JsonProperty("followers_count")]
        public int FollowersCount { get; set; }

        [JsonProperty("following_count")]
        public int FollowingCount { get; set; }

        [JsonProperty("mute_expires_at")]
        public DateTime? MuteExpiresAt { get; set; }
    }

    public class AccountField
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("verified_at")]
        public DateTime? VerifiedAt { get; set; }
    }
}
