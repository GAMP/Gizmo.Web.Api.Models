using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Refund options.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class RefundOptions
    {
        #region PROPERTIES
        
        /// <summary>
        /// The Id of the payment method to use for the refund.
        /// </summary>
        [Key(0)]
        public int? RefundMethodId { get; set; } 

        #endregion
    }
}
