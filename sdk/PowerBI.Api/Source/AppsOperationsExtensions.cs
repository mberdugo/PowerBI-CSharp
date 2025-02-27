// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AppsOperations.
    /// </summary>
    public static partial class AppsOperationsExtensions
    {
            /// <summary>
            /// Returns a list of installed apps.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// App.Read.All
            ///
            /// ## Limitations
            ///
            /// Service principal authentication is not supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Apps GetApps(this IAppsOperations operations)
            {
                return operations.GetAppsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of installed apps.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// App.Read.All
            ///
            /// ## Limitations
            ///
            /// Service principal authentication is not supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Apps> GetAppsAsync(this IAppsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAppsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the specified installed app.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// App.Read.All
            ///
            /// ## Limitations
            ///
            /// Service principal authentication is not supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app ID
            /// </param>
            public static App GetApp(this IAppsOperations operations, System.Guid appId)
            {
                return operations.GetAppAsync(appId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the specified installed app.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// App.Read.All
            ///
            /// ## Limitations
            ///
            /// Service principal authentication is not supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<App> GetAppAsync(this IAppsOperations operations, System.Guid appId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAppWithHttpMessagesAsync(appId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of reports from the specified app.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Report.ReadWrite.All or Report.Read.All
            ///
            /// ## Limitations
            ///
            /// Service principal authentication is not supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app ID
            /// </param>
            public static Reports GetReports(this IAppsOperations operations, System.Guid appId)
            {
                return operations.GetReportsAsync(appId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of reports from the specified app.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Report.ReadWrite.All or Report.Read.All
            ///
            /// ## Limitations
            ///
            /// Service principal authentication is not supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Reports> GetReportsAsync(this IAppsOperations operations, System.Guid appId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetReportsWithHttpMessagesAsync(appId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the specified report from the specified app.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Report.ReadWrite.All or Report.Read.All
            ///
            /// ## Limitations
            ///
            /// Service principal authentication is not supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app ID
            /// </param>
            /// <param name='reportId'>
            /// The report ID
            /// </param>
            public static Report GetReport(this IAppsOperations operations, System.Guid appId, System.Guid reportId)
            {
                return operations.GetReportAsync(appId, reportId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the specified report from the specified app.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Report.ReadWrite.All or Report.Read.All
            ///
            /// ## Limitations
            ///
            /// Service principal authentication is not supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app ID
            /// </param>
            /// <param name='reportId'>
            /// The report ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Report> GetReportAsync(this IAppsOperations operations, System.Guid appId, System.Guid reportId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetReportWithHttpMessagesAsync(appId, reportId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of dashboards from the specified app.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Dashboard.ReadWrite.All or Dashboard.Read.All
            ///
            /// ## Limitations
            ///
            /// Service principal authentication is not supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app ID
            /// </param>
            public static Dashboards GetDashboards(this IAppsOperations operations, System.Guid appId)
            {
                return operations.GetDashboardsAsync(appId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of dashboards from the specified app.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Dashboard.ReadWrite.All or Dashboard.Read.All
            ///
            /// ## Limitations
            ///
            /// Service principal authentication is not supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Dashboards> GetDashboardsAsync(this IAppsOperations operations, System.Guid appId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDashboardsWithHttpMessagesAsync(appId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the specified dashboard from the specified app.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Dashboard.ReadWrite.All or Dashboard.Read.All
            ///
            /// ## Limitations
            ///
            /// Service principal authentication is not supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app ID
            /// </param>
            /// <param name='dashboardId'>
            /// The dashboard ID
            /// </param>
            public static Dashboard GetDashboard(this IAppsOperations operations, System.Guid appId, System.Guid dashboardId)
            {
                return operations.GetDashboardAsync(appId, dashboardId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the specified dashboard from the specified app.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Dashboard.ReadWrite.All or Dashboard.Read.All
            ///
            /// ## Limitations
            ///
            /// Service principal authentication is not supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app ID
            /// </param>
            /// <param name='dashboardId'>
            /// The dashboard ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Dashboard> GetDashboardAsync(this IAppsOperations operations, System.Guid appId, System.Guid dashboardId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDashboardWithHttpMessagesAsync(appId, dashboardId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of tiles within the specified dashboard from the specified
            /// app.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Dashboard.ReadWrite.All or Dashboard.Read.All
            ///
            /// ## Limitations
            ///
            /// Service principal authentication is not supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app ID
            /// </param>
            /// <param name='dashboardId'>
            /// The dashboard ID
            /// </param>
            public static Tiles GetTiles(this IAppsOperations operations, System.Guid appId, System.Guid dashboardId)
            {
                return operations.GetTilesAsync(appId, dashboardId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of tiles within the specified dashboard from the specified
            /// app.
            /// </summary>
            /// <remarks>
            ///
            /// ## Required scope
            ///
            /// Dashboard.ReadWrite.All or Dashboard.Read.All
            ///
            /// ## Limitations
            ///
            /// Service principal authentication is not supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app ID
            /// </param>
            /// <param name='dashboardId'>
            /// The dashboard ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Tiles> GetTilesAsync(this IAppsOperations operations, System.Guid appId, System.Guid dashboardId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTilesWithHttpMessagesAsync(appId, dashboardId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the specified tile within the specified dashboard from the
            /// specified app.
            /// </summary>
            /// <remarks>
            ///
            /// All tile types, except *model tiles*, are supported. Supported tiles
            /// include datasets and live tiles that contain an entire report page.
            ///
            /// ## Required scope
            ///
            /// Dashboard.ReadWrite.All or Dashboard.Read.All
            ///
            /// ## Limitations
            ///
            /// Service principal authentication is not supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app ID
            /// </param>
            /// <param name='dashboardId'>
            /// The dashboard ID
            /// </param>
            /// <param name='tileId'>
            /// The tile ID
            /// </param>
            public static Tile GetTile(this IAppsOperations operations, System.Guid appId, System.Guid dashboardId, System.Guid tileId)
            {
                return operations.GetTileAsync(appId, dashboardId, tileId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the specified tile within the specified dashboard from the
            /// specified app.
            /// </summary>
            /// <remarks>
            ///
            /// All tile types, except *model tiles*, are supported. Supported tiles
            /// include datasets and live tiles that contain an entire report page.
            ///
            /// ## Required scope
            ///
            /// Dashboard.ReadWrite.All or Dashboard.Read.All
            ///
            /// ## Limitations
            ///
            /// Service principal authentication is not supported.
            ///
            /// ######
            ///
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app ID
            /// </param>
            /// <param name='dashboardId'>
            /// The dashboard ID
            /// </param>
            /// <param name='tileId'>
            /// The tile ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Tile> GetTileAsync(this IAppsOperations operations, System.Guid appId, System.Guid dashboardId, System.Guid tileId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTileWithHttpMessagesAsync(appId, dashboardId, tileId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of apps in the organization. This is a preview API call.
            /// </summary>
            /// <remarks>
            ///
            /// The query parameter $top is required.
            ///
            /// ## Permissions
            ///
            /// Delegated permissions are supported.
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
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// The requested number of entries in the refresh history. If not provided,
            /// the default is all available entries.
            /// </param>
            public static Apps GetAppsAsAdmin(this IAppsOperations operations, int top)
            {
                return operations.GetAppsAsAdminAsync(top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of apps in the organization. This is a preview API call.
            /// </summary>
            /// <remarks>
            ///
            /// The query parameter $top is required.
            ///
            /// ## Permissions
            ///
            /// Delegated permissions are supported.
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
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// The requested number of entries in the refresh history. If not provided,
            /// the default is all available entries.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Apps> GetAppsAsAdminAsync(this IAppsOperations operations, int top, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAppsAsAdminWithHttpMessagesAsync(top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of users that have access to the specified app. This is a
            /// preview API call.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// - The user must have administrator rights (such as Office 365 Global
            /// Administrator or Power BI Service Administrator) or authenticate using a
            /// service principal.
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
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app ID
            /// </param>
            public static AppUsers GetAppUsersAsAdmin(this IAppsOperations operations, System.Guid appId)
            {
                return operations.GetAppUsersAsAdminAsync(appId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of users that have access to the specified app. This is a
            /// preview API call.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// - The user must have administrator rights (such as Office 365 Global
            /// Administrator or Power BI Service Administrator) or authenticate using a
            /// service principal.
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
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The app ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AppUsers> GetAppUsersAsAdminAsync(this IAppsOperations operations, System.Guid appId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAppUsersAsAdminWithHttpMessagesAsync(appId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
