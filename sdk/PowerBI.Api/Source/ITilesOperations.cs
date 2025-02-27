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
    /// TilesOperations operations.
    /// </summary>
    public partial interface ITilesOperations
    {
        /// <summary>
        /// Generates an embed token to view the specified tile from the
        /// specified workspace.&lt;br/&gt;&lt;br/&gt;This API is relevant only
        /// to ['App owns data' embed
        /// scenario](https://docs.microsoft.com/power-bi/developer/embed-sample-for-customers).
        /// Generates an embed token to view the specified tile from the
        /// specified workspace.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: (all of the below)
        /// &lt;ul&gt;&lt;li&gt;Dashboard.ReadWrite.All or
        /// Dashboard.Read.All&lt;/li&gt;&lt;li&gt;Report.ReadWrite.All or
        /// Report.Read.All &lt;/li&gt;&lt;li&gt;Dataset.ReadWrite.All or
        /// Dataset.Read.All&lt;/li&gt;&lt;/ul&gt;To set the permissions scope,
        /// see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).&lt;br/&gt;When
        /// using service principal for authentication, refer to [Service
        /// Principal with Power
        /// BI](https://docs.microsoft.com/power-bi/developer/embed-service-principal)
        /// document along with considerations and limitations section.
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace ID
        /// </param>
        /// <param name='dashboardId'>
        /// The dashboard ID
        /// </param>
        /// <param name='tileId'>
        /// The tile ID
        /// </param>
        /// <param name='requestParameters'>
        /// Generate token parameters
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<EmbedToken>> GenerateTokenInGroupWithHttpMessagesAsync(System.Guid groupId, System.Guid dashboardId, System.Guid tileId, GenerateTokenRequest requestParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
