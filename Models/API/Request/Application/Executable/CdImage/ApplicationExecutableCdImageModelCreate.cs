using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable cd image.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationExecutableCdImageModelCreate : IApplicationExecutableCdImageApiModel
    {
        #region PROPERTIES

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
