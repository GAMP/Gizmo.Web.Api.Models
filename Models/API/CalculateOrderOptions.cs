using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Calculate order options.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class CalculateOrderOptions : CalculateOrderOptionsModelBase
    {
        #region PROPERTIES
        
        /// <summary>
        /// The Id of the payment method that is preferred.
        /// </summary>
        [Key(100)]
        public int? PreferredPaymentMethodId { get; set; } 

        #endregion
    }
}