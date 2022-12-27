using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Application.Executable.Model
{
    /// <summary>
    /// Application executable.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationExecutableModelUpdate : IApplicationExecutableApiModel, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Required]
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// Whether the executable is accessible.
        /// </summary>
        [MessagePack.Key(1)]
        public bool Accessible { get; set; }

        /// <summary>
        /// The caption of the executable.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(2)]
        public string Caption { get; set; }

        /// <summary>
        /// The description of the executable.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(3)]
        public string Description { get; set; }

        /// <summary>
        /// The application modes object attached to this executable.
        /// </summary>
        [MessagePack.Key(4)]
        public ApplicationModes ApplicationModes { get; set; }

        /// <summary>
        /// The path of the executable.
        /// </summary>
        [Required]
        [StringLength(255)]
        [MessagePack.Key(5)]
        public string ExecutablePath { get; set; }

        /// <summary>
        /// The working directory of the executable.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(6)]
        public string WorkingDirectory { get; set; }

        /// <summary>
        /// The arguments of the executable.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(7)]
        public string Arguments { get; set; }

        /// <summary>
        /// The run mode of the executable.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(8)]
        public RunMode RunMode { get; set; }

        /// <summary>
        /// The license reservation type of the executable.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(9)]
        public LicenseReservationType ReservationType { get; set; }

        /// <summary>
        /// The executable options object attached to this executable.
        /// </summary>
        [MessagePack.Key(10)]
        public ApplicationExecutableOptions ExecutableOptions { get; set; }

        /// <summary>
        /// The display order of the executable.
        /// </summary>
        [MessagePack.Key(11)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// The Id of the application this executable belongs to.
        /// </summary>
        [MessagePack.Key(12)]
        public int ApplicationId { get; set; }

        /// <summary>
        /// The Id of the deployment profile this executable uses by default.
        /// </summary>
        [MessagePack.Key(13)]
        public int? DefaultDeploymentId { get; set; }

        #endregion
    }
}
