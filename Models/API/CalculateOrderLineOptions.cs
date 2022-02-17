using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Calculate order line options.
    /// </summary>
    [Serializable]
    [DataContract]
    public class CalculateOrderLineOptions : IUrlQueryParameters
    {
        /// <summary>
        /// The type of the order line.
        /// </summary>
        [DataMember]
        [EnumValue]
        public LineType LineType { get; set; }

        /// <summary>
        /// The quantity of items in the order line.
        /// </summary>
        [DataMember]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Whether to use the custom price for this order line. 
        /// </summary>
        [DataMember]
        public bool IsCustomPrice { get; set; }

        /// <summary>
        /// The custom price of the order line.
        /// </summary>
        [DataMember]
        public decimal? CustomPrice { get; set; }

        /// <summary>
        /// The product object attached to this order line if the order line refers to a product, otherwise it will be null.
        /// </summary>
        [DataMember]
        public LineProduct Product { get; set; }

        /// <summary>
        /// The time product object attached to this order line if the order line refers to a time product, otherwise it will be null.
        /// </summary>
        [DataMember]
        public LineProduct TimeProduct { get; set; }

        /// <summary>
        /// The fixed time object attached to this order line if the order line refers to fixed time, otherwise it will be null.
        /// </summary>
        [DataMember]
        public LineFixedTime FixedTime { get; set; }

    }
}