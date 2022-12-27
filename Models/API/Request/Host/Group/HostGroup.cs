﻿using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Host.Group
{
    /// <summary>
    /// Host group.
    /// </summary>
    [MessagePackObject]
    public sealed class HostGroup : IHostGroupApiModel, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The name of the host group.
        /// </summary>
        [MessagePack.Key(1)]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        /// <summary>
        /// The name of the skin this host group uses by default.
        /// </summary>
        [MessagePack.Key(2)]
        [StringLength(255)]
        public string SkinName { get; set; }

        /// <summary>
        /// The Id of the application profile this host group is associated with.
        /// </summary>
        [MessagePack.Key(3)]
        public int? ApplicationGroupId { get; set; }

        /// <summary>
        /// The Id of the security profile this host group is associated with.
        /// </summary>
        [MessagePack.Key(4)]
        public int? SecurityProfileId { get; set; }

        /// <summary>
        /// The Id of the guest group this host group uses by default.
        /// </summary>
        [MessagePack.Key(5)]
        public int? DefaultGuestGroupId { get; set; }

        #endregion
    }
}