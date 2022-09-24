using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for operators.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class OperatorsFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES
        
        /// <summary>
        /// Return operators with usernames that contain the specified string.
        /// </summary>
        [Key(200)]
        public string Username { get; set; }

        /// <summary>
        /// Return disabled operators.
        /// </summary>
        [Key(201)]
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// Return deleted operators.
        /// </summary>
        [Key(202)]
        public bool? IsDeleted { get; set; } 

        #endregion
    }
}
