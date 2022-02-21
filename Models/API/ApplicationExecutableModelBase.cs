﻿using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ApplicationExecutableModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// Whether the executable is accessible.
        /// </summary>
        [DataMember]
        [MessagePack.Key(0)]
        public bool Accessible { get; set; }

        /// <summary>
        /// The caption of the executable.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        [MessagePack.Key(1)]
        public string Caption { get; set; }

        /// <summary>
        /// The description of the executable.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        [MessagePack.Key(2)]
        public string Description { get; set; }

        /// <summary>
        /// The application modes object attached to this executable.
        /// </summary>
        [DataMember]
        [MessagePack.Key(3)]
        public ApplicationModes ApplicationModes { get; set; }

        /// <summary>
        /// The path of the executable.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        [MessagePack.Key(4)]
        public string ExecutablePath { get; set; }

        /// <summary>
        /// The working directory of the executable.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        [MessagePack.Key(5)]
        public string WorkingDirectory { get; set; }

        /// <summary>
        /// The arguments of the executable.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        [MessagePack.Key(6)]
        public string Arguments { get; set; }

        /// <summary>
        /// The run mode of the executable.
        /// </summary>
        [DataMember]
        [EnumValue]
        [MessagePack.Key(7)]
        public RunMode RunMode { get; set; }

        /// <summary>
        /// The license reservation type of the executable.
        /// </summary>
        [DataMember]
        [EnumValue]
        [MessagePack.Key(8)]
        public LicenseReservationType ReservationType { get; set; }

        /// <summary>
        /// The executable options object attached to this executable.
        /// </summary>
        [DataMember]
        [MessagePack.Key(9)]
        public ApplicationExecutableOptions ExecutableOptions { get; set; }

        /// <summary>
        /// The display order of the executable.
        /// </summary>
        [DataMember]
        [MessagePack.Key(10)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// The Id of the application this executable belongs to.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(11)]
        public int ApplicationId { get; set; }

        /// <summary>
        /// The Id of the deployment profile this executable uses by default.
        /// </summary>
        [DataMember]
        [MessagePack.Key(12)]
        public int? DefaultDeploymentId { get; set; }

        #endregion
    }
}