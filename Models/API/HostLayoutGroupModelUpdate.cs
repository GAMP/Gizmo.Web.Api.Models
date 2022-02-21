using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host layout group.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class HostLayoutGroupModelUpdate : HostLayoutGroupModelBase, IEntityBase, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        [Required]
        public int Id { get; set; }

        #endregion
    }
}