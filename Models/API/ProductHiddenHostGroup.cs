using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product hidden host group.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ProductHiddenHostGroup : ProductHiddenHostGroupModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the product.
        /// </summary>
        [DataMember]
        public int ProductId { get; set; }

        #endregion
    }
}
