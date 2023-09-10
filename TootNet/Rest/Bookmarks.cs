// Generated by TootNet.Generator.  DO NOT EDIT!

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TootNet.Internal;
using TootNet.Objects;

namespace TootNet.Rest
{
    public class Bookmarks : ApiBase
    {
        internal Bookmarks(Tokens e) : base(e) { }

        /// <summary>
        /// <para>View bookmarked statuses</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> max_id (optional)</para>
        /// <para>- <c>long</c> since_id (optional)</para>
        /// <para>- <c>long</c> min_id (optional)</para>
        /// <para>- <c>int</c> limit (optional)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the list of status object.</para>
        /// </returns>
        public Task<Linked<Objects.Status>> GetAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessApiAsync<Linked<Objects.Status>>(MethodType.Get, "bookmarks", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="GetAsync(Expression{Func{string, object}}[])"/>
        public Task<Linked<Objects.Status>> GetAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessApiAsync<Linked<Objects.Status>>(MethodType.Get, "bookmarks", parameters);
        }

        /// <summary>
        /// <para>Bookmark a status</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the status object.</para>
        /// </returns>
        public Task<Objects.Status> BookmarkAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Status>(MethodType.Post, "statuses/{id}/bookmark", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="BookmarkAsync(Expression{Func{string, object}}[])"/>
        public Task<Objects.Status> BookmarkAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Status>(MethodType.Post, "statuses/{id}/bookmark", "id", parameters);
        }

        /// <summary>
        /// <para>Undo bookmark of a status</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the status object.</para>
        /// </returns>
        public Task<Objects.Status> UnbookmarkAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Status>(MethodType.Post, "statuses/{id}/unbookmark", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="UnbookmarkAsync(Expression{Func{string, object}}[])"/>
        public Task<Objects.Status> UnbookmarkAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Status>(MethodType.Post, "statuses/{id}/unbookmark", "id", parameters);
        }
    }
}
