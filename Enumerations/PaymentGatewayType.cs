namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment gateway type.
    /// </summary>
    public enum PaymentGatewayType
    {
        /// <summary>
        /// Payment provider.
        /// </summary>
        PaymentProvider = 0,

        /// <summary>
        /// Payment terminal (bank).
        /// </summary>
        PaymentTerminal = 1,
    }
}
