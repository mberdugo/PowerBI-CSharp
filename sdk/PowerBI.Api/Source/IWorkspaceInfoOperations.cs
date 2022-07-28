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
    /// WorkspaceInfoOperations operations.
    /// </summary>
    public partial interface IWorkspaceInfoOperations
    {
        /// <summary>
        /// Initiates a call to receive metadata for the requested list of
        /// workspaces.
        /// </summary>
        /// <remarks>
        ///
        /// &gt; [!IMPORTANT]
        /// &gt; If you set the `datasetSchema` or `datasetExpressions`
        /// parameters to `true`, you must fully enable metadata scanning in
        /// order for data to be returned. For more information, see [Enable
        /// tenant settings for metadata
        /// scanning](/power-bi/admin/service-admin-metadata-scanning-setup#enable-tenant-settings-for-metadata-scanning).
        ///
        /// ## Permissions
        ///
        /// The user must have administrator rights (such as Microsoft 365
        /// Global Administrator or Power BI Service Administrator) or
        /// authenticate using a service principal.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// - Maximum 500 requests per hour.
        /// - Maximum 16 simultaneous requests.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='requiredWorkspaces'>
        /// Required workspace IDs to get info for
        /// </param>
        /// <param name='lineage'>
        /// Whether to return lineage info (upstream dataflows, tiles, data
        /// source IDs)
        /// </param>
        /// <param name='datasourceDetails'>
        /// Whether to return data source details
        /// </param>
        /// <param name='datasetSchema'>
        /// Whether to return dataset schema (tables, columns and measures). If
        /// you set this parameter to `true`, you must fully enable metadata
        /// scanning in order for data to be returned. For more information,
        /// see [Enable tenant settings for metadata
        /// scanning](/power-bi/admin/service-admin-metadata-scanning-setup#enable-tenant-settings-for-metadata-scanning).
        /// </param>
        /// <param name='datasetExpressions'>
        /// Whether to return dataset expressions (DAX and Mashup queries). If
        /// you set this parameter to `true`, you must fully enable metadata
        /// scanning in order for data to be returned. For more information,
        /// see [Enable tenant settings for metadata
        /// scanning](/power-bi/admin/service-admin-metadata-scanning-setup#enable-tenant-settings-for-metadata-scanning).
        /// </param>
        /// <param name='getArtifactUsers'>
        /// Whether to return user details for a Power BI item (such as a
        /// report or a dashboard)
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
        Task<HttpOperationResponse<ScanRequest>> PostWorkspaceInfoWithHttpMessagesAsync(RequiredWorkspaces requiredWorkspaces, bool? lineage = default(bool?), bool? datasourceDetails = default(bool?), bool? datasetSchema = default(bool?), bool? datasetExpressions = default(bool?), bool? getArtifactUsers = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the scan status for the specified scan.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// The user must have administrator rights (such as Microsoft 365
        /// Global Administrator or Power BI Service Administrator) or
        /// authenticate using a service principal.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Maximum 10,000 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='scanId'>
        /// The scan ID, which is included in the response from the workspaces
        /// or the [Admin - WorkspaceInfo
        /// PostWorkspaceInfo](/rest/api/power-bi/admin/workspace-info-post-workspace-info)
        /// API call that triggered the scan.
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
        Task<HttpOperationResponse<ScanRequest>> GetScanStatusWithHttpMessagesAsync(System.Guid scanId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the scan result for the specified scan.
        /// </summary>
        /// <remarks>
        ///
        /// Only make this API call after a successful
        /// [GetScanStatus](/rest/api/power-bi/admin/workspace-info-get-scan-status)
        /// API call. The scan result will remain available for 24 hours.
        ///
        /// ## Permissions
        ///
        /// The user must have administrator rights (such as Microsoft 365
        /// Global Administrator or Power BI Service Administrator) or
        /// authenticate using a service principal.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Maximum 500 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='scanId'>
        /// The scan ID, which is included in the response from the workspaces
        /// or the [Admin - WorkspaceInfo
        /// PostWorkspaceInfo](/rest/api/power-bi/admin/workspace-info-post-workspace-info)
        /// API call that triggered the scan.
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
        Task<HttpOperationResponse<WorkspaceInfoResponse>> GetScanResultWithHttpMessagesAsync(System.Guid scanId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of workspace IDs in the organization.
        /// </summary>
        /// <remarks>
        ///
        /// If the optional `modifiedSince` parameter is set to a date-time,
        /// only the IDs of workspaces that changed after that date-time are
        /// returned. If the `modifiedSince` parameter isn't used, the IDs of
        /// all workspaces in the organization are returned. The date-time
        /// specified by the `modifiedSince` parameter must be in the range of
        /// 30 minutes (to allow workspace changes to take effect) to 30 days
        /// prior to the current time.
        ///
        /// ## Permissions
        ///
        /// The user must have administrator rights (such as Microsoft 365
        /// Global Administrator or Power BI Service Administrator) or
        /// authenticate using a service principal.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Maximum 30 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='modifiedSince'>
        /// Last modified date (must be in ISO 8601 compliant UTC format)
        /// </param>
        /// <param name='excludePersonalWorkspaces'>
        /// Whether to exclude personal workspaces
        /// </param>
        /// <param name='excludeInActiveWorkspaces'>
        /// Whether to exclude inactive workspaces
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
        Task<HttpOperationResponse<IList<ModifiedWorkspace>>> GetModifiedWorkspacesWithHttpMessagesAsync(System.DateTime? modifiedSince = default(System.DateTime?), bool? excludePersonalWorkspaces = default(bool?), bool? excludeInActiveWorkspaces = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
