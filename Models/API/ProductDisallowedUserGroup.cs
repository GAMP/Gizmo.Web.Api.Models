using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product disallowed user group.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ProductDisallowedUserGroup : ProductDisallowedUserGroupModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        [MessagePack.Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the product.
        /// </summary>
        [DataMember]
        [MessagePack.Key(101)]
        public int ProductId { get; set; }

        #endregion
    }
}