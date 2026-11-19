using System;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filter to get the state of a payment of the current user.
    /// </summary>
    [MessagePackObject]
    public sealed class UserPaymentIntentFilter : IWebApiModel
    {
        /// <summary>
        /// Payment intent id.
        /// </summary>
        [Key(0)]
        public Guid Intent { get; set; }
    }
}
