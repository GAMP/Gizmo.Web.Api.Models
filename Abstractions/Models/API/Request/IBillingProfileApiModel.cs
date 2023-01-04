namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Billing profile.
    /// </summary>
    public interface IBillingProfileApiModel
    {
        /// <summary>
        /// The default rate of the billing profile.
        /// </summary>
        BillingProfileRate DefaultRate { get; set; }

        /// <summary>
        /// The name of the billing profile.
        /// </summary>
        string Name { get; set; }
    }
}