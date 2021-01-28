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
    public class ApplicationGroupModelUpdate : ApplicationGroupModelBase, IEntityBase
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
