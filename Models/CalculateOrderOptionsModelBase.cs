using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Calculate order options.
    /// </summary>
    [Serializable]
    [DataContract]
    public class CalculateOrderOptionsModelBase
    {
        /// <summary>
        /// The lines of the order.
        /// </summary>
        [DataMember]
        public IEnumerable<CalculateOrderLineOptions> OrderLines { get; set; }
    }
}