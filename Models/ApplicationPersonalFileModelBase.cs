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
        /// Gets or sets list of files that should be excluded.
        /// <remarks>Each entry should be seperated by ; character.</remarks>
        /// </summary>
        [DataMember]
        public string ExcludeFiles { get; set; }

        /// <summary>
        /// Gets or sets list of directories that should be excluded.
        /// <remarks>Each entry should be seperated by ; character.</remarks>
        /// </summary>
        [DataMember]
        public string ExcludeDirectories { get; set; }

        /// <summary>
        /// Gets or sets list of files that should be included.
        /// <remarks>Each entry should be seperated by ; character.</remarks>
        /// </summary>
        [DataMember]
        public string IncludeFiles { get; set; }

        /// <summary>
        /// Gets or sets list of directories that should be included.
        /// <remarks>Each entry should be seperated by ; character.</remarks>
        /// </summary>
        [DataMember]
        public string IncludeDirectories { get; set; }

        #endregion
    }
}