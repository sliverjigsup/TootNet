﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TootNet.Internal;
using TootNet.Objects;

namespace TootNet.Rest
{
    public class DomainBlocks : ApiBase
    {
        internal DomainBlocks(Tokens e) : base(e) { }

        /// <summary>
        /// <para>Returns blocked domain.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> max_id (optional)</para>
        /// <para>- <c>long</c> since_id (optional)</para>
        /// <para>- <c>int</c> limit (optional)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns list of string.</para>
        /// </returns>
        public Task<Linked<string>> GetAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessApiAsync<Linked<string>>(MethodType.Get, "domain_blocks", Utils.ExpressionToDictionary(parameters));
        }

        /// <summary>
        /// <para>Returns blocked domain.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> max_id (optional)</para>
        /// <para>- <c>long</c> since_id (optional)</para>
        /// <para>- <c>int</c> limit (optional)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns list of string.</para>
        /// </returns>
        public Task<Linked<string>> GetAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessApiAsync<Linked<string>>(MethodType.Get, "domain_blocks", parameters);
        }

        /// <summary>
        /// <para>Block target domain.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>string</c> domain (required)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns empty object.</para>
        /// </returns>
        public Task PostAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessApiAsync(MethodType.Post, "domain_blocks", Utils.ExpressionToDictionary(parameters));
        }

        /// <summary>
        /// <para>Block target domain.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>string</c> domain (required)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns empty object.</para>
        /// </returns>
        public Task PostAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessApiAsync(MethodType.Post, "domain_blocks", parameters);
        }

        /// <summary>
        /// <para>Delete blocked target domain.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>string</c> domain (required)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns empty object.</para>
        /// </returns>
        public Task DeleteAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessApiAsync(MethodType.Delete, "domain_blocks", Utils.ExpressionToDictionary(parameters));
        }

        /// <summary>
        /// <para>Delete blocked target domain.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>string</c> domain (required)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns empty object.</para>
        /// </returns>
        public Task DeleteAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessApiAsync(MethodType.Delete, "domain_blocks", parameters);
        }
    }
}