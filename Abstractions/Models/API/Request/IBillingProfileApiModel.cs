namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Request
{
    /// <summary>
    /// Billing profile.
    /// </summary>
    public interface IBillingProfileApiModel
    {
        /// <summary>
        /// The default rate of the billing profile.
        /// </summary>
        BillingProfileRateModel DefaultRate { get; set; }

        /// <summary>
        /// The name of the billing profile.
        /// </summary>
        string Name { get; set; }
    }
}