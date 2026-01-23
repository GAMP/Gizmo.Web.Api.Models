namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User billing options set model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserBillingOptionsSetModel : IWebApiModel
    {
        /// <summary>
        /// Gets or sets options.
        /// </summary>
        [MessagePack.Key(0)]
        public BillingOption? Options { get; set; }
    }
}
