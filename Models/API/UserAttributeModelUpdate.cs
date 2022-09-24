﻿using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User attribute.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class UserAttributeModelUpdate : UserAttributeModelBase, IEntityBase, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Required]
        [MessagePack.Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the user this attribute belongs to.
        /// </summary>
        [Required]
        [MessagePack.Key(101)]
        public int UserId { get; set; }

        #endregion
    }
}
