namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Verification method chain context.
    /// </summary>
    /// <remarks>
    /// Identifies the chain a verification method entry belongs to. <see cref="Global"/> applies to all
    /// flows; more specific contexts may be added in the future to form separate chains, resolved most
    /// specific first with fallback to <see cref="Global"/>.
    /// </remarks>
    public enum VerificationContext
    {
        /// <summary>
        /// Global chain, applies to all flows.
        /// </summary>
        Global = 0,
    }
}
