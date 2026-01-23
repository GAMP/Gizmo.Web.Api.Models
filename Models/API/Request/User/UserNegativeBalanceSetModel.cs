namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User negative balance set model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class UserNegativeBalanceSetModel : IWebApiModel
    {
        /// <summary>
        /// Enables user negative balance.
        /// </summary>
        /// <remarks>
        /// Leave null to fallback to user group settings, set value to override it.
        /// </remarks>
        [MessagePack.Key(0)]
        public bool? IsEnabled { get; set; }
    }
}
