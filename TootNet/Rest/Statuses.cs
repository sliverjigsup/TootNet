// Generated by TootNet.Generator.  DO NOT EDIT!

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TootNet.Internal;
using TootNet.Objects;

namespace TootNet.Rest
{
    public class Statuses : ApiBase
    {
        internal Statuses(Tokens e) : base(e) { }

        /// <summary>
        /// <para>Post a new status.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>string</c> status (required)</para>
        /// <para>- <c>IEnumerable&lt;long&gt;</c> media_ids (required)</para>
        /// <para>- <c>IEnumerable&lt;string&gt;</c> poll[options] (required)</para>
        /// <para>- <c>int</c> poll[expires_in] (required)</para>
        /// <para>- <c>bool</c> poll[multiple] (optional)</para>
        /// <para>- <c>bool</c> poll[hide_totals] (optional)</para>
        /// <para>- <c>long</c> in_reply_to_id (optional)</para>
        /// <para>- <c>bool</c> sensitive (optional)</para>
        /// <para>- <c>string</c> spoiler_text (optional)</para>
        /// <para>- <c>string</c> visibility (optional)</para>
        /// <para>- <c>string</c> language (ISO 639-1 language two-letter code) (optional)</para>
        /// <para>- <c>string</c> scheduled_at (format: "2019-01-01 12:00:00") (optional)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the status object.</para>
        /// </returns>
        public Task<Objects.Status> PostAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessApiAsync<Objects.Status>(MethodType.Post, "statuses", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="PostAsync(Expression{Func{string, object}}[])"/>
        public Task<Objects.Status> PostAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessApiAsync<Objects.Status>(MethodType.Post, "statuses", parameters);
        }

        /// <summary>
        /// <para>View a single status.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the status object.</para>
        /// </returns>
        public Task<Objects.Status> IdAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Status>(MethodType.Get, "statuses/{id}", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="IdAsync(Expression{Func{string, object}}[])"/>
        public Task<Objects.Status> IdAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Status>(MethodType.Get, "statuses/{id}", "id", parameters);
        }

        /// <summary>
        /// <para>Delete a status.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the status object.</para>
        /// </returns>
        public Task<Objects.Status> DeleteAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Status>(MethodType.Delete, "statuses/{id}", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="DeleteAsync(Expression{Func{string, object}}[])"/>
        public Task<Objects.Status> DeleteAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Status>(MethodType.Delete, "statuses/{id}", "id", parameters);
        }

        /// <summary>
        /// <para>Get parent and child statuses in context.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the context object.</para>
        /// </returns>
        public Task<Objects.Context> ContextAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Context>(MethodType.Get, "statuses/{id}/context", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="ContextAsync(Expression{Func{string, object}}[])"/>
        public Task<Objects.Context> ContextAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Context>(MethodType.Get, "statuses/{id}/context", "id", parameters);
        }

        /// <summary>
        /// <para>Translate a status.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// <para>- <c>string</c> lang (ISO 639-1 language two-letter code) (optional)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the translation object.</para>
        /// </returns>
        public Task<Objects.Translation> TranslateAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Translation>(MethodType.Post, "statuses/{id}/translate", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="TranslateAsync(Expression{Func{string, object}}[])"/>
        public Task<Objects.Translation> TranslateAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Translation>(MethodType.Post, "statuses/{id}/translate", "id", parameters);
        }

        /// <summary>
        /// <para>See who boosted a status.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// <para>- <c>long</c> max_id (optional)</para>
        /// <para>- <c>long</c> since_id (optional)</para>
        /// <para>- <c>int</c> limit (optional)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the list of account object.</para>
        /// </returns>
        public Task<Linked<Objects.Account>> RebloggedByAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Linked<Objects.Account>>(MethodType.Get, "statuses/{id}/reblogged_by", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="RebloggedByAsync(Expression{Func{string, object}}[])"/>
        public Task<Linked<Objects.Account>> RebloggedByAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Linked<Objects.Account>>(MethodType.Get, "statuses/{id}/reblogged_by", "id", parameters);
        }

        /// <summary>
        /// <para>See who favourited a status.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// <para>- <c>long</c> max_id (optional)</para>
        /// <para>- <c>long</c> since_id (optional)</para>
        /// <para>- <c>int</c> limit (optional)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the list of account object.</para>
        /// </returns>
        public Task<Linked<Objects.Account>> FavouritedByAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Linked<Objects.Account>>(MethodType.Get, "statuses/{id}/favourited_by", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="FavouritedByAsync(Expression{Func{string, object}}[])"/>
        public Task<Linked<Objects.Account>> FavouritedByAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Linked<Objects.Account>>(MethodType.Get, "statuses/{id}/favourited_by", "id", parameters);
        }

        /// <summary>
        /// <para>Boost a status.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// <para>- <c>string</c> visibility (optional)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the status object.</para>
        /// </returns>
        public Task<Objects.Status> ReblogAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Status>(MethodType.Post, "statuses/{id}/reblog", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="ReblogAsync(Expression{Func{string, object}}[])"/>
        public Task<Objects.Status> ReblogAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Status>(MethodType.Post, "statuses/{id}/reblog", "id", parameters);
        }

        /// <summary>
        /// <para>Undo boost of a status.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the status object.</para>
        /// </returns>
        public Task<Objects.Status> UnreblogAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Status>(MethodType.Post, "statuses/{id}/unreblog", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="UnreblogAsync(Expression{Func{string, object}}[])"/>
        public Task<Objects.Status> UnreblogAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Status>(MethodType.Post, "statuses/{id}/unreblog", "id", parameters);
        }

        /// <summary>
        /// <para>Mute a conversation.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the status object.</para>
        /// </returns>
        public Task<Objects.Status> MuteAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Status>(MethodType.Post, "statuses/{id}/mute", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="MuteAsync(Expression{Func{string, object}}[])"/>
        public Task<Objects.Status> MuteAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Status>(MethodType.Post, "statuses/{id}/mute", "id", parameters);
        }

        /// <summary>
        /// <para>Unmute a conversation.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the status object.</para>
        /// </returns>
        public Task<Objects.Status> UnmuteAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Status>(MethodType.Post, "statuses/{id}/unmute", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="UnmuteAsync(Expression{Func{string, object}}[])"/>
        public Task<Objects.Status> UnmuteAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Status>(MethodType.Post, "statuses/{id}/unmute", "id", parameters);
        }

        /// <summary>
        /// <para>Pin status to profile.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the status object.</para>
        /// </returns>
        public Task<Objects.Status> PinAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Status>(MethodType.Post, "statuses/{id}/pin", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="PinAsync(Expression{Func{string, object}}[])"/>
        public Task<Objects.Status> PinAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Status>(MethodType.Post, "statuses/{id}/pin", "id", parameters);
        }

        /// <summary>
        /// <para>Unpin status from profile.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the status object.</para>
        /// </returns>
        public Task<Objects.Status> UnpinAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Status>(MethodType.Post, "statuses/{id}/unpin", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="UnpinAsync(Expression{Func{string, object}}[])"/>
        public Task<Objects.Status> UnpinAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Status>(MethodType.Post, "statuses/{id}/unpin", "id", parameters);
        }

        /// <summary>
        /// <para>Edit a status.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// <para>- <c>string</c> status (optional)</para>
        /// <para>- <c>string</c> spoiler_text (optional)</para>
        /// <para>- <c>bool</c> sensitive (optional)</para>
        /// <para>- <c>string</c> language (ISO 639-1 language two-letter code) (optional)</para>
        /// <para>- <c>IEnumerable&lt;long&gt;</c> media_ids (optional)</para>
        /// <para>- <c>IEnumerable&lt;string&gt;</c> poll[options] (optional)</para>
        /// <para>- <c>int</c> poll[expires_in] (optional)</para>
        /// <para>- <c>bool</c> poll[multiple] (optional)</para>
        /// <para>- <c>bool</c> poll[hide_totals] (optional)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the status object.</para>
        /// </returns>
        public Task<Objects.Status> PutAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Status>(MethodType.Put, "statuses/{id}", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="PutAsync(Expression{Func{string, object}}[])"/>
        public Task<Objects.Status> PutAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Status>(MethodType.Put, "statuses/{id}", "id", parameters);
        }

        /// <summary>
        /// <para>View edit history of a status.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the list of statusedit object.</para>
        /// </returns>
        public Task<ListResponce<Objects.StatusEdit>> HistoryAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<ListResponce<Objects.StatusEdit>>(MethodType.Get, "statuses/{id}/history", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="HistoryAsync(Expression{Func{string, object}}[])"/>
        public Task<ListResponce<Objects.StatusEdit>> HistoryAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<ListResponce<Objects.StatusEdit>>(MethodType.Get, "statuses/{id}/history", "id", parameters);
        }

        /// <summary>
        /// <para>View status source.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the statussource object.</para>
        /// </returns>
        public Task<Objects.StatusSource> SourceAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.StatusSource>(MethodType.Get, "statuses/{id}/source", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="SourceAsync(Expression{Func{string, object}}[])"/>
        public Task<Objects.StatusSource> SourceAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.StatusSource>(MethodType.Get, "statuses/{id}/source", "id", parameters);
        }
    }
}
