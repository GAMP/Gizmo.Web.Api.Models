namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// License result codes.
    /// </summary>
    public enum LicenseResult
    {
        /// <summary>
        /// Signed license is available.
        /// </summary>
        Available = 0,

        /// <summary>
        /// Signed license is not available on the server.
        /// </summary>
        NotAvailable = 1,
    }
}
