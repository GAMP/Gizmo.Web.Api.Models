using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Application.PersonalFile.Model
{
    /// <summary>
    /// Application personal file.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationPersonalFileModelUpdate : IApplicationPersonalFileApiModel, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The type of the personal file.
        /// </summary>
        [MessagePack.Key(1)]
        [EnumValueValidation]
        public PersonalUserFileType Type { get; set; }

        /// <summary>
        /// The name of the personal file.
        /// </summary>
        [MessagePack.Key(2)]
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// The caption of the personal file.
        /// </summary>
        [MessagePack.Key(3)]
        [StringLength(255)]
        public string Caption { get; set; }

        /// <summary>
        /// The description of the personal file.
        /// </summary>
        [MessagePack.Key(4)]
        [StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// Whether the personal file is accessible.
        /// </summary>
        [MessagePack.Key(5)]
        public bool Accessible { get; set; }

        /// <summary>
        /// The source path of the personal file.
        /// </summary>
        [MessagePack.Key(6)]
        [Required]
        [StringLength(255)]
        public string Source { get; set; }

        /// <summary>
        /// The activation type of the personal file.
        /// </summary>
        [MessagePack.Key(7)]
        [EnumValueValidation]
        public PersonalFileActivationType Activation { get; set; }

        /// <summary>
        /// The quota of the personal file.
        /// </summary>
        [MessagePack.Key(8)]
        public int MaxQuota { get; set; }

        /// <summary>
        /// The compression level of the personal file.
        /// </summary>
        [MessagePack.Key(9)]
        public int CompressionLevel { get; set; }

        /// <summary>
        /// Whether to clean up before restore.
        /// </summary>
        [MessagePack.Key(10)]
        public bool CleanUp { get; set; }

        /// <summary>
        /// Whether to store the personal file.
        /// </summary>
        [MessagePack.Key(11)]
        public bool Store { get; set; }

        /// <summary>
        /// The directory options object attached to this personal file if the personal file type is file, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(12)]
        public ApplicationPersonalFileDirectoryOptions DirectoryOptions { get; set; }

        #endregion
    }
}
