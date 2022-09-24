﻿using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable license.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationExecutableLicenseModelUpdate : ApplicationExecutableLicenseModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the executable this license is associated with.
        /// </summary>
        [Required]
        [MessagePack.Key(100)]
        public int ApplicationExecutableId { get; set; }

        #endregion
    }
}
