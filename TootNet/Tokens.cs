﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TootNet.Internal;
using TootNet.Rest;

namespace TootNet
{
    public class Tokens : TokensBase
    {
        public Tokens(string instance, string accessToken, string clientId = null, string clientSecret = null) : base()
        {
            Instance = instance;
            AccessToken = accessToken;
            ClientId = clientId;
            ClientSecret = clientSecret;
        }

        /// <summary>
        /// Accounts
        /// </summary>
        public Accounts Accounts => new Accounts(this);

        /// <summary>
        /// Apps
        /// </summary>
        public Apps Apps => new Apps(this);

        /// <summary>
        /// Blocks
        /// </summary>
        public Blocks Blocks => new Blocks(this);

        /// <summary>
        /// Favorites
        /// </summary>
        public Favourites Favourites => new Favourites(this);

        /// <summary>
        /// FollowRequests
        /// </summary>
        public FollowRequests FollowRequests => new FollowRequests(this);

        /// <summary>
        /// Follows
        /// </summary>
        public Follows Follows => new Follows(this);

        /// <summary>
        /// Instances
        /// </summary>
        public Instances Instances => new Instances(this);

        /// <summary>
        /// Media
        /// </summary>
        public Media Media => new Media(this);

        /// <summary>
        /// Mutes
        /// </summary>
        public Mutes Mutes => new Mutes(this);

        /// <summary>
        /// Notifications
        /// </summary>
        public Notifications Notifications => new Notifications(this);

        /// <summary>
        /// Reports
        /// </summary>
        public Reports Reports => new Reports(this);

        /// <summary>
        /// Search
        /// </summary>
        public Search Search => new Search(this);

        /// <summary>
        /// Statuses
        /// </summary>
        public Statuses Statuses => new Statuses(this);

        /// <summary>
        /// Timelines
        /// </summary>
        public Timelines Timelines => new Timelines(this);

        /// <summary>
        /// <para>Send request to target uri.</para>
        /// </summary>
        /// <param name="type">Method type of request.</param>
        /// <param name="uri">Relative path of accessing uri.</param>
        /// <param name="param">The parameter.</param>
        /// <param name="headers">Headers of request.</param>
        /// <returns>
        /// <para>AsyncResponse of request.</para>
        /// </returns>
        public async Task<AsyncResponse> SendRequestAsync(MethodType type, string uri, IEnumerable<KeyValuePair<string, object>> param = null, IDictionary<string, string> headers = null)
        {
            using (var httpClient = ConnectionOptions.GetHttpClient())
            {
                switch (type)
                {
                    case MethodType.Get:
                        return await Request.HttpGetAsync(httpClient, uri, param, headers);
                    case MethodType.Post:
                        return await Request.HttpPostAsync(httpClient, uri, param, headers);
                    case MethodType.Delete:
                        return await Request.HttpDeleteAsync(httpClient, uri, param, headers);
                }
            }

            return null;
        }

        /// <summary>
        /// <para>Access mastodon api targeted in uri field.</para>
        /// </summary>
        /// <param name="type">Method type of request.</param>
        /// <param name="uri">Uri to access (relative path from API).</param>
        /// <param name="param">The parameter.</param>
        /// <param name="headers">Headers of request.</param>
        /// <returns>
        /// <para>AsyncResponse of request.</para>
        /// </returns>
        public Task<T> AccessApiAsync<T>(MethodType type, string uri, IEnumerable<KeyValuePair<string, object>> param = null, IDictionary<string, string> headers = null) where T : class
        {
            return AccessApiAsyncImpl<T>(type, ConstructUri(uri), param, headers);
        }

        /// <summary>
        /// <para>Access mastodon api targeted in uri field.</para>
        /// </summary>
        /// <param name="type">Method type of request.</param>
        /// <param name="uri">Uri to access (relative path from API).</param>
        /// <param name="reserved">Reserved parameter (relative path from API).</param>
        /// <param name="param">The parameter.</param>
        /// <param name="headers">Headers of request.</param>
        /// <returns>
        /// <para>AsyncResponse of request.</para>
        /// </returns>
        public Task<T> AccessParameterReservedApiAsync<T>(MethodType type, string uri, string reserved, IDictionary<string, object> param = null, IDictionary<string, string> headers = null) where T : class
        {
            if (param == null)
                throw new ArgumentNullException(nameof(param));
            var list = param.ToList();
            var kvp = Utils.GetReservedParameter(list, reserved);
            list.Remove(kvp);
            return AccessApiAsyncImpl<T>(type, uri.Replace(string.Format("{{{0}}}", reserved), kvp.Value.ToString()), list, headers);
        }

        private async Task<T> AccessApiAsyncImpl<T>(MethodType type, string uri, IEnumerable<KeyValuePair<string, object>> param = null, IDictionary<string, string> headers = null) where T : class
        {
            using (var response = await SendRequestAsync(type, uri, param, headers).ConfigureAwait(false))
            {
                var json = await response.GetResponseStringAsync();
                var obj = Converter.Convert<T>(json);

                return obj;
            }
        }
    }
}