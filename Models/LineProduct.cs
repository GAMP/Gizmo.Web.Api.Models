using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Line product.
    /// </summary>
    [Serializable]
    [DataContract]
    public class LineProduct
    {
        /// <summary>
        /// The Id of the product.
        /// </summary>
        [DataMember]
        public int ProductId { get; set; }
    }
}
