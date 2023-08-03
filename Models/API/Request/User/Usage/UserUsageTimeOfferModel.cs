using System;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserUsageTimeOfferModel
    {
        /// <summary>
        /// Identifier of the invoice line.
        /// </summary>
        [Key(0)] public int InvoiceLineId { get; set; }
    }
}
