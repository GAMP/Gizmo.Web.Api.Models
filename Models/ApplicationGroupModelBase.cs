using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application group.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationGroupModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the application group.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        #endregion
    }
}
