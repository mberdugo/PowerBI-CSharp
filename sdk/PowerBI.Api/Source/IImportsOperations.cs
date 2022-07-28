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
    /// ImportsOperations operations.
    /// </summary>
    public partial interface IImportsOperations
    {
        /// <summary>
        /// Returns a list of imports from **My workspace**.
        /// </summary>
        /// <remarks>
        ///
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All or Dataset.Read.All
        /// &lt;br&gt;&lt;br&gt;
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
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<Imports>> GetImportsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates new content in **My workspace**.
        /// </summary>
        /// <remarks>
        ///
        /// &gt; [!NOTE]
        /// &gt; Supported content:
        /// &gt; - Power BI .pbix files
        /// &gt; - JSON files (.json)
        /// &gt; - Excel files (.xlsx)
        /// &gt; - RDL files (.rdl)
        ///
        /// - To import a file, specify the content type
        /// **multipart/form-data** in the request headers and encode the file
        /// as [form data](https://www.w3.org/TR/html401/interact/forms.html)
        /// in the request body.
        /// - To import an .rdl file, include the file extension in the name
        /// specified by `datasetDisplayName`, as described in [URI
        /// parameters](/rest/api/power-bi/imports/post-import-in-group#uri-parameters).
        /// - To import an .xlsx file from OneDrive for Business, include the
        /// content type **application/json** in the request headers. Include
        /// [ImportInfo](/rest/api/power-bi/imports/post-import-in-group#importinfo)
        /// with `filePath` set to the .xlsx file path in the request body.
        /// - To import large Power BI .pbix files that are between 1 GB and 10
        /// GB in size, see [Create Temporary Upload
        /// Location](/rest/api/power-bi/imports/create-temporary-upload-location).
        /// This is only supported for Premium capacity workspaces.
        /// - To create a dataflow from a model.json file, set
        /// `datasetDisplayName` to *model.json*, as described in [URI
        /// parameters](/rest/api/power-bi/imports/post-import-in-group#uri-parameters).
        ///
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// - Dataflows with service principal aren't supported.
        /// - Importing a Power BI .pbix file from OneDrive isn't supported.
        /// - Importing a file that has a **protected** sensitivity label isn't
        /// supported for service principals.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='datasetDisplayName'>
        /// The display name of the dataset, should include file extension. Not
        /// supported when importing from OneDrive for Business.
        /// </param>
        /// <param name='importInfo'>
        /// The import to post
        /// </param>
        /// <param name='nameConflict'>
        /// Specifies what to do if a dataset with the same name already
        /// exists. The default value is `Ignore`. For RDL files, `Abort` and
        /// `Overwrite` are the only supported options. Possible values
        /// include: 'Ignore', 'Abort', 'Overwrite', 'CreateOrOverwrite',
        /// 'GenerateUniqueName'
        /// </param>
        /// <param name='skipReport'>
        /// Whether to skip report import. If specified, the value must be
        /// `true`. Only supported for Power BI .pbix files.
        /// </param>
        /// <param name='overrideReportLabel'>
        /// Whether to override the existing report label when republishing a
        /// Power BI .pbix file. The service default value is `true`.
        /// </param>
        /// <param name='overrideModelLabel'>
        /// Whether to override the existing label on a model when republishing
        /// a Power BI .pbix file. The service default value is `true`.
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
        Task<HttpOperationResponse<Import>> PostImportWithHttpMessagesAsync(string datasetDisplayName, ImportInfo importInfo, ImportConflictHandlerMode? nameConflict = default(ImportConflictHandlerMode?), bool? skipReport = default(bool?), bool? overrideReportLabel = default(bool?), bool? overrideModelLabel = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the specified import from **My workspace**.
        /// </summary>
        /// <remarks>
        ///
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All or Dataset.Read.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='importId'>
        /// The import ID
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
        Task<HttpOperationResponse<Import>> GetImportWithHttpMessagesAsync(System.Guid importId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a temporary blob storage upload location for importing
        /// large Power BI .pbix files that are between 1 GB and 10 GB in size.
        /// </summary>
        /// <remarks>
        ///
        /// To import large Power BI .pbix files:
        ///
        /// 1. Create a temporary upload location using this API call.
        /// 1. Upload the Power BI .pbix files using the *shared access
        /// signature* URL from the API call response.
        /// 1. Call [Post Import In
        /// Group](/rest/api/power-bi/imports/post-import), specifying the
        /// *shared access signature* URL in the `fileUrl` parameter of the
        /// [request
        /// body](/rest/api/power-bi/imports/post-import#request-body).
        ///
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Importing large Power BI .pbix files between 1 GB and 10 GB in size
        /// is only available for Premium capacity workspaces.
        /// &lt;br&gt;&lt;br&gt;
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
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<TemporaryUploadLocation>> CreateTemporaryUploadLocationWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of imports from the specified workspace.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// This API call can be called by a service principal profile. For
        /// more information see: [Service principal profiles in Power BI
        /// Embedded](/power-bi/developer/embedded/embed-multi-tenancy).
        ///
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All or Dataset.Read.All
        ///
        /// ## Limitations
        ///
        /// Importing Power BI .pbix files from OneDrive isn't supported.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace ID
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
        Task<HttpOperationResponse<Imports>> GetImportsInGroupWithHttpMessagesAsync(System.Guid groupId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates new content in the specified workspace.
        /// </summary>
        /// <remarks>
        ///
        /// &gt; [!NOTE]
        /// &gt; Supported content:
        /// &gt;
        /// &gt; - Power BI .pbix files
        /// &gt; - JSON files (.json)
        /// &gt; - Excel files (.xlsx)
        /// &gt; - SQL Server Report Definition Language files (.rdl)
        ///
        /// - To import a file, specify the content type
        /// **multipart/form-data** in the request headers and encode the file
        /// as [form data](https://www.w3.org/TR/html401/interact/forms.html)
        /// in the request body.
        /// - To import an .rdl file, include the file extension in the name
        /// specified by `datasetDisplayName`, as described in [URI
        /// parameters](/rest/api/power-bi/imports/post-import-in-group#uri-parameters).
        /// - To import an .xlsx file from OneDrive for Business, include the
        /// content type **application/json** in the request headers. Include
        /// [ImportInfo](/rest/api/power-bi/imports/post-import-in-group#importinfo)
        /// with `filePath` set to the .xlsx file path in the request body.
        /// - To import large Power BI .pbix files that are between 1 GB and 10
        /// GB in size, see [Create Temporary Upload Location In
        /// Group](/rest/api/power-bi/imports/create-temporary-upload-location-in-group).
        /// This is only supported for Premium capacity workspaces.
        /// - To create a dataflow from a model.json file, set
        /// `datasetDisplayName` to *model.json*, as described in [URI
        /// parameters](/rest/api/power-bi/imports/post-import-in-group#uri-parameters).
        ///
        /// ## Permissions
        ///
        /// This API call can be called by a service principal profile. For
        /// more information see: [Service principal profiles in Power BI
        /// Embedded](/power-bi/developer/embedded/embed-multi-tenancy).
        ///
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// - Dataflows with service principal aren't supported.
        /// - Importing a Power BI .pbix file from OneDrive isn't supported.
        /// - Importing a file that has a **protected** sensitivity label isn't
        /// supported for service principals.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace ID
        /// </param>
        /// <param name='datasetDisplayName'>
        /// The display name of the dataset should include file extension. Not
        /// supported when importing from OneDrive for Business. For importing
        /// or creating dataflows, this parameter should be hardcoded to
        /// model.json.
        /// </param>
        /// <param name='importInfo'>
        /// The import to post
        /// </param>
        /// <param name='nameConflict'>
        /// Specifies what to do if a dataset with the same name already
        /// exists. The default value is `Ignore`. For RDL files, `Abort` and
        /// `Overwrite` are the only supported options. For dataflow model.json
        /// files, `Abort` and `GenerateUniqueName` are the only supported
        /// options. Possible values include: 'Ignore', 'Abort', 'Overwrite',
        /// 'CreateOrOverwrite', 'GenerateUniqueName'
        /// </param>
        /// <param name='skipReport'>
        /// Whether to skip report import. If specified, the value must be
        /// `true`. Only supported for Power BI .pbix files.
        /// </param>
        /// <param name='overrideReportLabel'>
        /// Whether to override the existing label on a report when
        /// republishing a Power BI .pbix file. The service default value is
        /// `true`.
        /// </param>
        /// <param name='overrideModelLabel'>
        /// Determines whether to override the existing label on a model when
        /// republishing a Power BI .pbix file. The service default value is
        /// `true`.
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
        Task<HttpOperationResponse<Import>> PostImportInGroupWithHttpMessagesAsync(System.Guid groupId, string datasetDisplayName, ImportInfo importInfo, ImportConflictHandlerMode? nameConflict = default(ImportConflictHandlerMode?), bool? skipReport = default(bool?), bool? overrideReportLabel = default(bool?), bool? overrideModelLabel = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the specified import from the specified workspace.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// This API call can be called by a service principal profile. For
        /// more information see: [Service principal profiles in Power BI
        /// Embedded](/power-bi/developer/embedded/embed-multi-tenancy).
        ///
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All or Dataset.Read.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace ID
        /// </param>
        /// <param name='importId'>
        /// The import ID
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
        Task<HttpOperationResponse<Import>> GetImportInGroupWithHttpMessagesAsync(System.Guid groupId, System.Guid importId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a temporary blob storage upload location for importing
        /// large Power BI .pbix files that are between 1 GB and 10 GB in size.
        /// </summary>
        /// <remarks>
        ///
        /// To import large Power BI .pbix files:
        ///
        /// 1. Create a temporary upload location using this API call.
        /// 1. Upload the Power BI .pbix files using the *shared access
        /// signature* URL from the API call response.
        /// 1. Call [Post Import In
        /// Group](/rest/api/power-bi/imports/post-import-in-group), specifying
        /// the *shared access signature* URL in the `fileUrl` parameter of the
        /// [request
        /// body](/rest/api/power-bi/imports/post-import-in-group#request-body).
        ///
        /// ## Permissions
        ///
        /// This API call can be called by a service principal profile. For
        /// more information see: [Service principal profiles in Power BI
        /// Embedded](/power-bi/developer/embedded/embed-multi-tenancy).
        ///
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Importing large Power BI .pbix files between 1 GB and 10 GB in size
        /// is only available for Premium capacity workspaces.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace ID
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
        Task<HttpOperationResponse<TemporaryUploadLocation>> CreateTemporaryUploadLocationInGroupWithHttpMessagesAsync(System.Guid groupId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of imports for the organization.
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
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Maximum 200 requests per hour.
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='expand'>
        /// Expands related entities inline
        /// </param>
        /// <param name='filter'>
        /// Filters the results, based on a boolean condition
        /// </param>
        /// <param name='top'>
        /// Returns only the first n results
        /// </param>
        /// <param name='skip'>
        /// Skips the first n results
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
        Task<HttpOperationResponse<Imports>> GetImportsAsAdminWithHttpMessagesAsync(string expand = default(string), string filter = default(string), int? top = default(int?), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
