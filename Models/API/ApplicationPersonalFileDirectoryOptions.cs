using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application personal file directory options.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ApplicationPersonalFileDirectoryOptions
    {
        /// <summary>
        /// Whether to include subdirectories.
        /// </summary>
        [DataMember]
        [MessagePack.Key(0)]
        public bool IncludeSubDirectories { get; set; }

        /// <summary>
        /// The list of files that should be excluded.
        /// <remarks>Each entry should be seperated by ; character.</remarks>
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public string ExcludeFiles { get; set; }

        /// <summary>
        /// The list of directories that should be excluded.
        /// <remarks>Each entry should be seperated by ; character.</remarks>
        /// </summary>
        [DataMember]
        [MessagePack.Key(2)]
        public string ExcludeDirectories { get; set; }

        /// <summary>
        /// The list of files that should be included.
        /// <remarks>Each entry should be seperated by ; character.</remarks>
        /// </summary>
        [DataMember]
        [MessagePack.Key(3)]
        public string IncludeFiles { get; set; }

        /// <summary>
        /// The list of directories that should be included.
        /// <remarks>Each entry should be seperated by ; character.</remarks>
        /// </summary>
        [DataMember]
        [MessagePack.Key(4)]
        public string IncludeDirectories { get; set; }
    }
}