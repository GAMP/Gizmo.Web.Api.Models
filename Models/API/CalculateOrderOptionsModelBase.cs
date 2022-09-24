using MessagePack;
using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Calculate order options.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class CalculateOrderOptionsModelBase : IUrlQueryParameters
    {
        #region PROPERTIES
        
        /// <summary>
        /// The lines of the order.
        /// </summary>
        [Key(0)]
        public IEnumerable<CalculateOrderLineOptions> OrderLines { get; set; } 

        #endregion
    }
}