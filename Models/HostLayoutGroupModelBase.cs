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
    public class HostLayoutGroupModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the host group.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        /// <summary>
        /// The display order of the layout group.
        /// </summary>
        [DataMember]
        public int DisplayOrder { get; set; }

        #endregion
    }
}