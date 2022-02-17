using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for application personal files.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationPersonalFilesFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return personal files with names that contain the specified string.
        /// </summary>
        [DataMember]
        public string PersonalFileName { get; set; }

        /// <summary>
        /// Return personal files with captions that contain the specified string.
        /// </summary>
        [DataMember]
        public string PersonalFileCaption { get; set; }
    }
}