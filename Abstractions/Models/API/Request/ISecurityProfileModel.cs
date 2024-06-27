namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Security profile.
    /// </summary>
    public interface ISecurityProfileModel : IWebApiModel
    {
        /// <summary>
        /// The name of the security profile.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The disabled drives of the security profile.
        /// </summary>
        int DisabledDrives { get; set; }
    }
}
