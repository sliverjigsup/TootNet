// Generated by TootNet.Generator.  DO NOT EDIT!

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TootNet.Internal;
using TootNet.Objects;

namespace TootNet.Rest
{
    public class Accounts : ApiBase
    {
        internal Accounts(Tokens e) : base(e) { }

        /// <summary>
        /// <para>Verify account credentials.</para>
        /// <para>Available parameters:</para>
        /// <para>- No parameters available in this method.</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the credentialaccount object.</para>
        /// </returns>
        public Task<Objects.CredentialAccount> VerifyCredentialsAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessApiAsync<Objects.CredentialAccount>(MethodType.Get, "accounts/verify_credentials", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="VerifyCredentialsAsync(Expression{Func{string, object}}[])"/>
        public Task<Objects.CredentialAccount> VerifyCredentialsAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessApiAsync<Objects.CredentialAccount>(MethodType.Get, "accounts/verify_credentials", parameters);
        }

        /// <summary>
        /// <para>Update account credentials.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>string</c> display_name (optional)</para>
        /// <para>- <c>string</c> note (optional)</para>
        /// <para>- <c>string</c> avatar (base64 encoded image string) (optional)</para>
        /// <para>- <c>string</c> header (base64 encoded image string) (optional)</para>
        /// <para>- <c>bool</c> locked (optional)</para>
        /// <para>- <c>bool</c> bot (optional)</para>
        /// <para>- <c>bool</c> discoverable (optional)</para>
        /// <para>- <c>string</c> fields_attributes[index][name] ([0]-[3] is allowed) (optional)</para>
        /// <para>- <c>string</c> fields_attributes[index][value] ([0]-[3] is allowed) (optional)</para>
        /// <para>- <c>string</c> source[privacy] (optional)</para>
        /// <para>- <c>bool</c> source[sensitive] (optional)</para>
        /// <para>- <c>string</c> source[language] (optional)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the credentialaccount object.</para>
        /// </returns>
        public Task<Objects.CredentialAccount> UpdateCredentialsAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessApiAsync<Objects.CredentialAccount>(MethodType.Patch, "accounts/update_credentials", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="UpdateCredentialsAsync(Expression{Func{string, object}}[])"/>
        public Task<Objects.CredentialAccount> UpdateCredentialsAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessApiAsync<Objects.CredentialAccount>(MethodType.Patch, "accounts/update_credentials", parameters);
        }

        /// <summary>
        /// <para>Get account.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the account object.</para>
        /// </returns>
        public Task<Objects.Account> IdAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Account>(MethodType.Get, "accounts/{id}", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="IdAsync(Expression{Func{string, object}}[])"/>
        public Task<Objects.Account> IdAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Account>(MethodType.Get, "accounts/{id}", "id", parameters);
        }

        /// <summary>
        /// <para>Get account's statuses.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// <para>- <c>long</c> max_id (optional)</para>
        /// <para>- <c>long</c> since_id (optional)</para>
        /// <para>- <c>long</c> min_id (optional)</para>
        /// <para>- <c>int</c> limit (optional)</para>
        /// <para>- <c>bool</c> only_media (optional)</para>
        /// <para>- <c>bool</c> exclude_replies (optional)</para>
        /// <para>- <c>bool</c> exclude_reblogs (optional)</para>
        /// <para>- <c>bool</c> pinned (optional)</para>
        /// <para>- <c>string</c> tagged (optional)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the list of status object.</para>
        /// </returns>
        public Task<Linked<Objects.Status>> StatusesAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Linked<Objects.Status>>(MethodType.Get, "accounts/{id}/statuses", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="StatusesAsync(Expression{Func{string, object}}[])"/>
        public Task<Linked<Objects.Status>> StatusesAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Linked<Objects.Status>>(MethodType.Get, "accounts/{id}/statuses", "id", parameters);
        }

        /// <summary>
        /// <para>Get account's followers.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// <para>- <c>long</c> max_id (optional)</para>
        /// <para>- <c>long</c> since_id (optional)</para>
        /// <para>- <c>long</c> min_id (optional)</para>
        /// <para>- <c>int</c> limit (optional)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the list of account object.</para>
        /// </returns>
        public Task<Linked<Objects.Account>> FollowersAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Linked<Objects.Account>>(MethodType.Get, "accounts/{id}/followers", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="FollowersAsync(Expression{Func{string, object}}[])"/>
        public Task<Linked<Objects.Account>> FollowersAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Linked<Objects.Account>>(MethodType.Get, "accounts/{id}/followers", "id", parameters);
        }

        /// <summary>
        /// <para>Get account's following.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// <para>- <c>long</c> max_id (optional)</para>
        /// <para>- <c>long</c> since_id (optional)</para>
        /// <para>- <c>long</c> min_id (optional)</para>
        /// <para>- <c>int</c> limit (optional)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the list of account object.</para>
        /// </returns>
        public Task<Linked<Objects.Account>> FollowingAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Linked<Objects.Account>>(MethodType.Get, "accounts/{id}/following", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="FollowingAsync(Expression{Func{string, object}}[])"/>
        public Task<Linked<Objects.Account>> FollowingAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Linked<Objects.Account>>(MethodType.Get, "accounts/{id}/following", "id", parameters);
        }

        /// <summary>
        /// <para>Get account's featured tags.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the list of featuredtag object.</para>
        /// </returns>
        public Task<ListResponse<Objects.FeaturedTag>> FeaturedTagsAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<ListResponse<Objects.FeaturedTag>>(MethodType.Get, "accounts/{id}/featured_tags", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="FeaturedTagsAsync(Expression{Func{string, object}}[])"/>
        public Task<ListResponse<Objects.FeaturedTag>> FeaturedTagsAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<ListResponse<Objects.FeaturedTag>>(MethodType.Get, "accounts/{id}/featured_tags", "id", parameters);
        }

        /// <summary>
        /// <para>Follow account.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// <para>- <c>bool</c> reblogs (optional)</para>
        /// <para>- <c>bool</c> notify (optional)</para>
        /// <para>- <c>IEnumerable&lt;string&gt;</c> languages (ISO 639-1 language two-letter code) (optional)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the relationship object.</para>
        /// </returns>
        public Task<Objects.Relationship> FollowAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Relationship>(MethodType.Post, "accounts/{id}/follow", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="FollowAsync(Expression{Func{string, object}}[])"/>
        public Task<Objects.Relationship> FollowAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Relationship>(MethodType.Post, "accounts/{id}/follow", "id", parameters);
        }

        /// <summary>
        /// <para>Unfollow account.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the relationship object.</para>
        /// </returns>
        public Task<Objects.Relationship> UnfollowAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Relationship>(MethodType.Post, "accounts/{id}/unfollow", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="UnfollowAsync(Expression{Func{string, object}}[])"/>
        public Task<Objects.Relationship> UnfollowAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Relationship>(MethodType.Post, "accounts/{id}/unfollow", "id", parameters);
        }

        /// <summary>
        /// <para>Remove account from followers.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the relationship object.</para>
        /// </returns>
        public Task<Objects.Relationship> RemoveFromFollowersAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Relationship>(MethodType.Post, "accounts/{id}/remove_from_followers", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="RemoveFromFollowersAsync(Expression{Func{string, object}}[])"/>
        public Task<Objects.Relationship> RemoveFromFollowersAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Relationship>(MethodType.Post, "accounts/{id}/remove_from_followers", "id", parameters);
        }

        /// <summary>
        /// <para>Set private note on profile.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>long</c> id (required)</para>
        /// <para>- <c>string</c> comment (optional)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the relationship object.</para>
        /// </returns>
        public Task<Objects.Relationship> NoteAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Relationship>(MethodType.Post, "accounts/{id}/note", "id", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="NoteAsync(Expression{Func{string, object}}[])"/>
        public Task<Objects.Relationship> NoteAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessParameterReservedApiAsync<Objects.Relationship>(MethodType.Post, "accounts/{id}/note", "id", parameters);
        }

        /// <summary>
        /// <para>Check relationships to other accounts.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>IEnumerable&lt;long&gt;</c> id (optional)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the list of relationship object.</para>
        /// </returns>
        public Task<ListResponse<Objects.Relationship>> RelationshipsAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessApiAsync<ListResponse<Objects.Relationship>>(MethodType.Get, "accounts/relationships", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="RelationshipsAsync(Expression{Func{string, object}}[])"/>
        public Task<ListResponse<Objects.Relationship>> RelationshipsAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessApiAsync<ListResponse<Objects.Relationship>>(MethodType.Get, "accounts/relationships", parameters);
        }

        /// <summary>
        /// <para>Find familiar followers.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>IEnumerable&lt;long&gt;</c> id (optional)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the list of familiarfollower object.</para>
        /// </returns>
        public Task<ListResponse<Objects.FamiliarFollower>> FamiliarFollowersAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessApiAsync<ListResponse<Objects.FamiliarFollower>>(MethodType.Get, "accounts/familiar_followers", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="FamiliarFollowersAsync(Expression{Func{string, object}}[])"/>
        public Task<ListResponse<Objects.FamiliarFollower>> FamiliarFollowersAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessApiAsync<ListResponse<Objects.FamiliarFollower>>(MethodType.Get, "accounts/familiar_followers", parameters);
        }

        /// <summary>
        /// <para>Search for matching accounts.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>string</c> q (required)</para>
        /// <para>- <c>int</c> limit (optional)</para>
        /// <para>- <c>int</c> offset (optional)</para>
        /// <para>- <c>bool</c> resolve (optional)</para>
        /// <para>- <c>bool</c> following (optional)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the list of account object.</para>
        /// </returns>
        public Task<ListResponse<Objects.Account>> SearchAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessApiAsync<ListResponse<Objects.Account>>(MethodType.Get, "accounts/search", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="SearchAsync(Expression{Func{string, object}}[])"/>
        public Task<ListResponse<Objects.Account>> SearchAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessApiAsync<ListResponse<Objects.Account>>(MethodType.Get, "accounts/search", parameters);
        }

        /// <summary>
        /// <para>Lookup account ID from Webfinger address.</para>
        /// <para>Available parameters:</para>
        /// <para>- <c>string</c> acct (required)</para>
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// <para>The task object representing the asynchronous operation.</para>
        /// <para>The Result property on the task object returns the account object.</para>
        /// </returns>
        public Task<Objects.Account> LookupAsync(params Expression<Func<string, object>>[] parameters)
        {
            return Tokens.AccessApiAsync<Objects.Account>(MethodType.Get, "accounts/lookup", Utils.ExpressionToDictionary(parameters));
        }

        /// <inheritdoc cref="LookupAsync(Expression{Func{string, object}}[])"/>
        public Task<Objects.Account> LookupAsync(IDictionary<string, object> parameters)
        {
            return Tokens.AccessApiAsync<Objects.Account>(MethodType.Get, "accounts/lookup", parameters);
        }
    }
}
