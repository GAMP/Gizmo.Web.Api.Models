using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host layout.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class HostLayout : HostLayoutModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the host layout group this host layout belongs to.
        /// </summary>
        [DataMember]
        public int HostLayoutGroupId { get; set; }

        #endregion
    }
}