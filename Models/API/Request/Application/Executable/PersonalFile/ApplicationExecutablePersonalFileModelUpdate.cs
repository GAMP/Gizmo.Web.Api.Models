using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Application.Executable.PersonalFile
{
    /// <summary>
    /// Application executable personal file.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationExecutablePersonalFileModelUpdate : IApplicationExecutablePersonalFileApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the executable this personal file is associated with.
        /// </summary>
        [Required]
        [MessagePack.Key(0)]
        public int ApplicationExecutableId { get; set; }

        /// <summary>
        /// The Id of the personal file associated with this application executable.
        /// </summary>
        [Required]
        [MessagePack.Key(1)]
        public int PersonalFileId { get; set; }

        /// <summary>
        /// The order in which the personal file is used.
        /// </summary>
        [MessagePack.Key(2)]
        public int UseOrder { get; set; }

        #endregion
    }
}
