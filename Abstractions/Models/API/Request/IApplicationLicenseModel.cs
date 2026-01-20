namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Application license.
    /// </summary>
    public interface IApplicationLicenseModel : IWebApiModel
    {
        /// <summary>
        /// The name of the license.
        /// </summary>
        string Name { get; set; }
    }
}
