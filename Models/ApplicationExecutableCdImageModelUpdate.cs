﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable cd image.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationExecutableCdImageModelUpdate : ApplicationExecutableCdImageModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the executable this cd image belongs to.
        /// </summary>
        [DataMember]
        [Required]
        public int ApplicationExecutableId { get; set; }

        #endregion
    }
}
