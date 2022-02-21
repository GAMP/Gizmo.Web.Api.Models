using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Time product disallowed host group.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class TimeProductDisallowedHostGroup : TimeProductDisallowedHostGroupModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the time product.
        /// </summary>
        [DataMember]
        public int TimeProductId { get; set; }

        #endregion
    }
}