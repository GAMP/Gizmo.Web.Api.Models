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
        
        /// <summary>
        /// Name of the invoice line product.
        /// </summary>
        [Key(1)] public string Name { get; set; } = null!;

        /// <summary>
        /// Whether the offer expires at logout.
        /// </summary>
        [Key(2)] public bool ExpiresAtLogout { get; set; }

        /// <summary>
        /// Sum of the invoice line.
        /// </summary>
        [Key(3)] public int AvailableMinutes { get; set; }
    }
}
