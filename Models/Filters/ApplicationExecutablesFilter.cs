using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for application executables.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationExecutablesFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES
        
        /// <summary>
        /// Return executables with captions that contain the specified string.
        /// </summary>
        [Key(200)]
        public string ExecutableCaption { get; set; }

        /// <summary>
        /// Return executables that belongs to the specified application.
        /// </summary>
        [Key(201)]
        public int? ApplicationId { get; set; } 

        #endregion
    }
}
