// Generated by TootNet.Generator.  DO NOT EDIT!

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TootNet.Internal;
using TootNet.Objects;

namespace TootNet.Rest
{
    public class Notifications : ApiBase
    {
        internal Notifications(Tokens e) : base(e) { }

        /// <summary>
        /// <para>Get all notifications.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> max_id (optional)</para>
        /// <para>- <c>long</c> since_id (optional)</para>
        /// <para>- <c>long</c> min_id (optional)</para>
        /// <para>- <c>int</c> limit (optional)</para>
        /// <para>- <c>IEnumerable&lt;string&gt;</c> types (allowed values: "mention", "status", "reblog", "follow", "follow_request", "favourite", "poll", "update") (optional)</para>
        /// <para>- <c>IEnumerable&lt;string&gt;</c> exclude_types (optional)</para>
        /// <para>- <c>long</c> account_id (optional)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the list of notification object.</para>
        /// </returns>
        public Task<Linked<Objects.Notification>> GetAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessApiAsync<Linked<Objects.Notification>>(MethodType.Get, "notifications", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="GetAsync(Expression{Func{string, object}}[])"/>
        public Task<Linked<Objects.Notification>> GetAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessApiAsync<Linked<Objects.Notification>>(MethodType.Get, "notifications", parameters);
        }

        /// <summary>
        /// <para>Get a single notification.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the notification object.</para>
        /// </returns>
        public Task<Objects.Notification> IdAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Notification>(MethodType.Get, "notifications/{id}", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="IdAsync(Expression{Func{string, object}}[])"/>
        public Task<Objects.Notification> IdAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Notification>(MethodType.Get, "notifications/{id}", "id", parameters);
        }

        /// <summary>
        /// <para>Dismiss all notifications.</para>
        /// <para>Available parameters:</para>
        /// <para>- No parameters available in this method.</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the empty object.</para>
        /// </returns>
        public Task ClearAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessApiAsync(MethodType.Post, "notifications/clear", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="ClearAsync(Expression{Func{string, object}}[])"/>
        public Task ClearAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessApiAsync(MethodType.Post, "notifications/clear", parameters);
        }

        /// <summary>
        /// <para>Dismiss a single notification.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the empty object.</para>
        /// </returns>
        public Task DismissAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync(MethodType.Post, "notifications/{id}/dismiss", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="DismissAsync(Expression{Func{string, object}}[])"/>
        public Task DismissAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync(MethodType.Post, "notifications/{id}/dismiss", "id", parameters);
        }
    }
}
