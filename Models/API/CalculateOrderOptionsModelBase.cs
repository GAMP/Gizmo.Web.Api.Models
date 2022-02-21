using MessagePack;
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
    [MessagePackObject]
    public class CalculateOrderOptionsModelBase : IUrlQueryParameters
    {
        /// <summary>
        /// The lines of the order.
        /// </summary>
        [DataMember]
        [MessagePack.Key(0)]
        public IEnumerable<CalculateOrderLineOptions> OrderLines { get; set; }
    }
}