using System;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Request to cancel a pending top up of the current user.
    /// </summary>
    [MessagePackObject]
    public sealed class UserPaymentIntentCancelModel : IWebApiModel
    {
        /// <summary>
        /// Payment intent id.
        /// </summary>
        [Key(0)]
        public Guid Intent { get; set; }
    }
}
