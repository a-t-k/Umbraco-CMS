using Umbraco.Cms.Web.BackOffice.Install;
using Umbraco.Cms.Web.Common.Routing;
using static Microsoft.AspNetCore.Routing.ControllerLinkGeneratorExtensions;
using Constants = Umbraco.Cms.Core.Constants;
namespace Umbraco.Extensions;

public static class BackofficeLinkGeneratorExtensions
{
    /// <summary>
    ///     Returns the URL for the installer
    /// </summary>
    public static string? GetInstallerUrl(this LinkGenerator linkGenerator)
        => linkGenerator.GetPathByAction(nameof(InstallController.Index), ControllerExtensions.GetControllerName<InstallController>(), new { area = Constants.Web.Mvc.InstallArea });

    /// <summary>
    ///     Returns the URL for the installer api
    /// </summary>
    public static string? GetInstallerApiUrl(this LinkGenerator linkGenerator)
        => linkGenerator.GetPathByAction(
            nameof(InstallApiController.GetSetup),
            ControllerExtensions.GetControllerName<InstallApiController>(),
            new { area = Constants.Web.Mvc.InstallArea })?.TrimEnd(nameof(InstallApiController.GetSetup));
}

[Obsolete("Please use Umbraco.Cms.Web.Common.Routing.LinkGenerator instead.")]
public static class BackofficeMIcrosoftLinkGeneratorExtensions
{
    /// <summary>
    /// Returns the URL for the installer
    /// </summary>
    [Obsolete("Please use Umbraco.Cms.Web.Common.Routing.LinkGenerator instead.")]
    public static string? GetInstallerUrl(this Microsoft.AspNetCore.Routing.LinkGenerator linkGenerator)
        => linkGenerator.GetPathByAction(nameof(InstallController.Index), ControllerExtensions.GetControllerName<InstallController>(), new { area = Constants.Web.Mvc.InstallArea });

    /// <summary>
    /// Returns the URL for the installer api
    /// </summary>
    [Obsolete("Please use Umbraco.Cms.Web.Common.Routing.LinkGenerator instead.")]
    public static string? GetInstallerApiUrl(this Microsoft.AspNetCore.Routing.LinkGenerator linkGenerator)
        => linkGenerator.GetPathByAction(
            nameof(InstallApiController.GetSetup),
            ControllerExtensions.GetControllerName<InstallApiController>(),
            new { area = Constants.Web.Mvc.InstallArea })?.TrimEnd(nameof(InstallApiController.GetSetup));
}
