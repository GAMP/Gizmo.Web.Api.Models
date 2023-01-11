﻿#nullable enable

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User attribute.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserAttributeModelCreate : IUserAttributeModel, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the attribute this user attribute is associated with.
        /// </summary>
        [MessagePack.Key(0)]
        public int AttributeId { get; set; }

        /// <summary>
        /// The value of the user attribute.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(255)]
        public string Value { get; set; } = null!;

        #endregion
    }
}
