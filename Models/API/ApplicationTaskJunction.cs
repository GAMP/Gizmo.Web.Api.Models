﻿using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application task junction.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationTaskJunction
    {
        #region PROPERTIES

        /// <summary>
        /// The source directory of the junction.
        /// </summary>
        [Required]
        [StringLength(255)]
        [MessagePack.Key(0)]
        public string SourceDirectory { get; set; }

        /// <summary>
        /// The destination directory of the junction.
        /// </summary>
        [Required]
        [StringLength(255)]
        [MessagePack.Key(1)]
        public string DestinationDirectory { get; set; }

        /// <summary>
        /// Whether the junction deletes the destination.
        /// </summary>
        [MessagePack.Key(2)]
        public bool DeleteDestination { get; set; }

        #endregion
    }
}