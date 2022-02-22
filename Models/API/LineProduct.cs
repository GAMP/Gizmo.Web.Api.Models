using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Line product.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class LineProduct : IUrlQueryParameters
    {
        /// <summary>
        /// The Id of the product.
        /// </summary>
        [DataMember]
        [MessagePack.Key(0)]
        public int ProductId { get; set; }
    }
}
