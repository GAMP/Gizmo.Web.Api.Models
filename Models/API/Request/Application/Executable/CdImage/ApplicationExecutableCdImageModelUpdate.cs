using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Application.Executable.CdImage
{
    /// <summary>
    /// Application executable cd image.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationExecutableCdImageModelUpdate : IApplicationExecutableCdImageApiModel, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Required]
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the executable this cd image belongs to.
        /// </summary>
        [Required]
        [MessagePack.Key(1)]
        public int ApplicationExecutableId { get; set; }

        /// <summary>
        /// The path of the cd image.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(2)]
        public string Path { get; set; }

        /// <summary>
        /// The mounting options of the cd image.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(3)]
        public string MountOptions { get; set; }

        /// <summary>
        /// The device id of the cd image.
        /// </summary>
        [StringLength(3)]
        [MessagePack.Key(4)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Whether the cd image will check the mounter process exit code value while mounting.
        /// </summary>
        [MessagePack.Key(5)]
        public bool CheckExitCode { get; set; }

        #endregion
    }
}
