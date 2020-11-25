using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    [Serializable]
    [DataContract]
    public class ProductImage : EntityBase
    {
        [DataMember]
        public byte[] Image { get; set; }
    }
}