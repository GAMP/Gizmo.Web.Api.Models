using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class Host : HostModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// The type of the host.
        /// </summary>
        [DataMember]
        [Required]
        [EnumValue]
        public HostType HostType { get; set; }

        #endregion
    }
}