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
    public class ApplicationExecutableModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// Whether the executable is accessible.
        /// </summary>
        [DataMember]
        public bool Accessible { get; set; }

        /// <summary>
        /// The caption of the executable.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        public string Caption { get; set; }

        /// <summary>
        /// The description of the executable.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// The application modes object attached to this executable.
        /// </summary>
        [DataMember]
        public ApplicationModes ApplicationModes { get; set; }

        /// <summary>
        /// The path of the executable.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        public string ExecutablePath { get; set; }

        /// <summary>
        /// The working directory of the executable.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        public string WorkingDirectory { get; set; }

        /// <summary>
        /// The arguments of the executable.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        public string Arguments { get; set; }

        /// <summary>
        /// The run mode of the executable.
        /// </summary>
        [DataMember]
        [EnumValue]
        public RunMode RunMode { get; set; }

        /// <summary>
        /// The license reservation type of the executable.
        /// </summary>
        [DataMember]
        [EnumValue]
        public LicenseReservationType ReservationType { get; set; }

        /// <summary>
        /// The executable options object attached to this executable.
        /// </summary>
        [DataMember]
        public ApplicationExecutableOptions ExecutableOptions { get; set; }

        /// <summary>
        /// The display order of the executable.
        /// </summary>
        [DataMember]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// The Id of the application this executable belongs to.
        /// </summary>
        [DataMember]
        [Required]
        public int ApplicationId { get; set; }

        /// <summary>
        /// The Id of the deployment profile this executable uses by default.
        /// </summary>
        [DataMember]
        public int? DefaultDeploymentId { get; set; }

        #endregion
    }
}