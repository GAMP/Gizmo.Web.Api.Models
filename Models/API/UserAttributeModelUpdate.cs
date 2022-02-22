﻿using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User attribute.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class UserAttributeModelUpdate : UserAttributeModelBase, IEntityBase, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the user this attribute belongs to.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(101)]
        public int UserId { get; set; }

        #endregion
    }
}
