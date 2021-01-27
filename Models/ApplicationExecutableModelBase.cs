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
        /// Gets or sets accessible.
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

        ///// <summary>
        ///// Gets or sets applications modes.
        ///// </summary>
        //[DataMember]
        //TODO: A public ApplicationModes Modes { get; set; }

        /// <summary>
        /// Gets or Sets path to the executable file.
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

        ///// <summary>
        ///// Gets or Sets the runmode of the executable.
        ///// </summary>
        //[DataMember]
        //TODO: A public RunMode RunMode { get; set; }

        ///// <summary>
        ///// Gets or sets license reservation type.
        ///// </summary>
        //[DataMember]
        //TODO: A public LicenseReservationType ReservationType { get; set; }

        ///// <summary>
        ///// Gets or sets executable options.
        ///// </summary>
        //[DataMember]
        //TODO: A public ExecutableOptionType Options { get; set; }

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
        /// Gets or sets default deployment profile.
        /// </summary>
        [DataMember]
        public int? DefaultDeploymentId { get; set; }

        #endregion
    }
}