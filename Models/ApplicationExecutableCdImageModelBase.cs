﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable cd image.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationExecutableCdImageModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The path of the cd image.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        public string Path { get; set; }

        /// <summary>
        /// The mounting options of the cd image.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        public string MountOptions { get; set; }

        /// <summary>
        /// The device id of the cd image.
        /// </summary>
        [DataMember]
        [StringLength(3)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Whether the cd image will check the mounter process exit code value while mounting.
        /// </summary>
        [DataMember]
        public bool CheckExitCode { get; set; }

        #endregion
    }
}