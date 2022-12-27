﻿using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Application.Group
{
    /// <summary>
    /// Application group.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationGroup : IApplicationGroupApiModel, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The GUID of the application group.
        /// </summary>
        [MessagePack.Key(1)]
        public Guid Guid { get; set; }

        /// <summary>
        /// The name of the application group.
        /// </summary>
        [MessagePack.Key(2)]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        #endregion
    }
}