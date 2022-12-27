﻿using MessagePack;

namespace Gizmo.Web.Api.Models.Models.API.Request
{
    /// <summary>
    /// Bundle.
    /// </summary>
    [MessagePackObject]
    public sealed class Bundle
    {
        #region PROPERTIES

        /// <summary>
        /// The stock options of the bundle.
        /// </summary>
        [Key(0)]
        public bool SelfStock { get; set; }

        #endregion
    }
}