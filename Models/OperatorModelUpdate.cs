﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Operator.
    /// </summary>
    [DataContract]
    [Serializable]
    public class OperatorModelUpdate : OperatorModelBase, IEntityBase, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// The new password for the operator, if left empty the password will remain the same.
        /// </summary>
        [DataMember]
        [StringLength(24)]
        public string Password { get; set; }

        #endregion
    }
}
