using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for application executables.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ApplicationExecutablesFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return executables with captions that contain the specified string.
        /// </summary>
        [DataMember]
        [MessagePack.Key(200)]
        public string ExecutableCaption { get; set; }

        /// <summary>
        /// Return executables that belongs to the specified application.
        /// </summary>
        [DataMember]
        [MessagePack.Key(201)]
        public int? ApplicationId { get; set; }
    }
}
