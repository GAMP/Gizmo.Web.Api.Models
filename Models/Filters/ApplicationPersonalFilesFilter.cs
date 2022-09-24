using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for application personal files.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationPersonalFilesFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES
        
        /// <summary>
        /// Return personal files with names that contain the specified string.
        /// </summary>
        [Key(200)]
        public string PersonalFileName { get; set; }

        /// <summary>
        /// Return personal files with captions that contain the specified string.
        /// </summary>
        [Key(201)]
        public string PersonalFileCaption { get; set; } 

        #endregion
    }
}