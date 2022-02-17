using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for application executables.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationExecutablesFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return executables with captions that contain the specified string.
        /// </summary>
        [DataMember]
        public string ExecutableCaption { get; set; }

        /// <summary>
        /// Return executables that belongs to the specified application.
        /// </summary>
        [DataMember]
        public int? ApplicationId { get; set; }
    }
}
