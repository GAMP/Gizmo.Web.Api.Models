using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application personal file.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ApplicationPersonalFileModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The type of the personal file.
        /// </summary>
        [DataMember]
        [EnumValueValidation]
        [MessagePack.Key(0)]
        public PersonalUserFileType Type { get; set; }

        /// <summary>
        /// The name of the personal file.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        [MessagePack.Key(1)]
        public string Name { get; set; }

        /// <summary>
        /// The caption of the personal file.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        [MessagePack.Key(2)]
        public string Caption { get; set; }

        /// <summary>
        /// The description of the personal file.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        [MessagePack.Key(3)]
        public string Description { get; set; }

        /// <summary>
        /// Whether the personal file is accessible.
        /// </summary>
        [DataMember]
        [MessagePack.Key(4)]
        public bool Accessible { get; set; }

        /// <summary>
        /// The source path of the personal file.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        [MessagePack.Key(5)]
        public string Source { get; set; }

        /// <summary>
        /// The activation type of the personal file.
        /// </summary>
        [DataMember]
        [EnumValueValidation]
        [MessagePack.Key(6)]
        public PersonalFileActivationType Activation { get; set; }

        /// <summary>
        /// The quota of the personal file.
        /// </summary>
        [DataMember]
        [MessagePack.Key(7)]
        public int MaxQuota { get; set; }

        /// <summary>
        /// The compression level of the personal file.
        /// </summary>
        [DataMember]
        [MessagePack.Key(8)]
        public int CompressionLevel { get; set; }

        /// <summary>
        /// Whether to clean up before restore.
        /// </summary>
        [DataMember]
        [MessagePack.Key(9)]
        public bool CleanUp { get; set; }

        /// <summary>
        /// Whether to store the personal file.
        /// </summary>
        [DataMember]
        [MessagePack.Key(10)]
        public bool Store { get; set; }

        /// <summary>
        /// The directory options object attached to this personal file if the personal file type is file, otherwise it will be null.
        /// </summary>
        [DataMember]
        [MessagePack.Key(11)]
        public ApplicationPersonalFileDirectoryOptions DirectoryOptions { get; set; }

        #endregion
    }
}