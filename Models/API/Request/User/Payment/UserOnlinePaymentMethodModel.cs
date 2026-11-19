using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Online payment method available to the user.
    /// </summary>
    [MessagePackObject]
    public sealed class UserOnlinePaymentMethodModel : IWebApiModel
    {
        /// <summary>
        /// Payment method id.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Payment method name.
        /// </summary>
        [Key(1)]
        public string Name { get; init; } = string.Empty;
    }
}
