using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for operators.
    /// </summary>
    [Serializable]
    [DataContract]
    public class OperatorsFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return operators with usernames that contain the specified string.
        /// </summary>
        [DataMember]
        public string Username { get; set; }

        /// <summary>
        /// Return disabled operators.
        /// </summary>
        [DataMember]
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// Return deleted operators.
        /// </summary>
        [DataMember]
        public bool? IsDeleted { get; set; }

    }
}
