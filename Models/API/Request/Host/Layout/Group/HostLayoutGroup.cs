﻿using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using Gizmo.Web.Api.Models.Models.API.Request.Host.Layout;
using MessagePack;
using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models.Models.API.Request.Host.Layout.Group
{
    /// <summary>
    /// Host layout group.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class HostLayoutGroup : HostLayoutGroupModelBase, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(2)]
        public int Id { get; set; }

        /// <summary>
        /// The host layouts of the host layout group.
        /// </summary>
        [Key(3)]
        public IEnumerable<HostLayout> HostLayouts { get; set; }

        #endregion
    }
}