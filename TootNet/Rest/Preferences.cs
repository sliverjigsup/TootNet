﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TootNet.Internal;

namespace TootNet.Rest
{
    public class Preferences : ApiBase
    {
        internal Preferences(Tokens e) : base(e) { }

        /// <summary>
        /// <para>Get user preferences.</para>
        /// <para>Available parameters:</para>
        /// <para>- No parameters available in this method.</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the dictionary object.</para>
        /// </returns>
        public Task<IDictionary<string, object>> GetAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessApiAsync<IDictionary<string, object>>(MethodType.Get, "preferences", Utils.ExpressionToDictionary(parameters));
        }

        /// <summary>
        /// <para>Get user preferences.</para>
        /// <para>Available parameters:</para>
        /// <para>- No parameters available in this method.</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the dictionary object.</para>
        /// </returns>
        public Task<IDictionary<string, object>> GetAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessApiAsync<IDictionary<string, object>>(MethodType.Get, "preferences", parameters);
        }
    }
}
