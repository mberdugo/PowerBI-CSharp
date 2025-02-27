// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Users operations.
    /// </summary>
    public partial interface IUsers
    {
        /// <summary>
        /// Refreshes user permissions in Power BI.
        /// </summary>
        /// <remarks>
        /// When a user is granted permissions to a workspace, app, or
        /// artifact, it might not be immediately available through API
        /// calls.&lt;br/&gt;This operation refreshes user permissions and
        /// makes sure the user permissions are fully
        /// updated.&lt;br/&gt;&lt;br/&gt;**Important:**&lt;ul&gt;&lt;li&gt;Make
        /// the *refresh user permissions* call, before any other API
        /// calls.&lt;/li&gt;&lt;li&gt;It takes about two minutes for the
        /// permissions to get refreshed. Before calling other APIs, wait for
        /// two minutes.&lt;/li&gt;&lt;/ul&gt;**Required scope:**
        /// Workspace.Read.All  or Workspace.ReadWrite.All&lt;br/&gt;To set the
        /// permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// &lt;h2&gt;Restrictions&lt;/h2&gt; User can call this API once per
        /// hour.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse> RefreshUserPermissionsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of artifacts that the given user have access to
        /// (Preview).
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// - The user must have administrator rights (such as Office 365
        /// Global Administrator or Power BI Service Administrator) or
        /// authenticate using a service principal.
        /// - Delegated permissions are supported.
        ///
        /// ## Required scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Maximum 200 requests per hour.
        ///
        /// ######
        ///
        /// </remarks>
        /// <param name='userGraphId'>
        /// The graph ID of user
        /// </param>
        /// <param name='continuationToken'>
        /// Token required to get the next chunk of the result set
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<ArtifactAccessResponse>> GetUserArtifactAccessAsAdminWithHttpMessagesAsync(System.Guid userGraphId, string continuationToken = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
