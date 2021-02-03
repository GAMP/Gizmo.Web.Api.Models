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
    public class ApplicationPersonalFileModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets caption.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        public string Caption { get; set; }

        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets accessible.
        /// </summary>
        [DataMember]
        public bool Accessible { get; set; }

        /// <summary>
        /// Gets or sets the source path.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets activation type.
        /// </summary>
        [DataMember]
        public PersonalFileActivationType Activation { get; set; }

        /// <summary>
        /// Gets or sets quota.
        /// </summary>
        [DataMember]
        public int MaxQuota { get; set; }

        /// <summary>
        /// Gets or sets compression level.
        /// </summary>
        [DataMember]
        public int CompressionLevel { get; set; }

        /// <summary>
        /// Gets or sets type.
        /// </summary>
        [DataMember]
        public PersonalUserFileType Type { get; set; }

        [DataMember]
        public bool CleanUp { get; set; }

        [DataMember]
        public bool Store { get; set; }

        [DataMember]
        public bool IncludeSubDirectories { get; set; }

        /// <summary>
        /// The list of files that should be excluded.
        /// <remarks>Each entry should be seperated by ; character.</remarks>
        /// </summary>
        [DataMember]
        public string ExcludeFiles { get; set; }

        /// <summary>
        /// The list of directories that should be excluded.
        /// <remarks>Each entry should be seperated by ; character.</remarks>
        /// </summary>
        [DataMember]
        public string ExcludeDirectories { get; set; }

        /// <summary>
        /// The list of files that should be included.
        /// <remarks>Each entry should be seperated by ; character.</remarks>
        /// </summary>
        [DataMember]
        public string IncludeFiles { get; set; }

        /// <summary>
        /// The list of directories that should be included.
        /// <remarks>Each entry should be seperated by ; character.</remarks>
        /// </summary>
        [DataMember]
        public string IncludeDirectories { get; set; }

        #endregion
    }
}