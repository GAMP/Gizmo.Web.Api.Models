using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for operators.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class OperatorsFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return operators with usernames that contain the specified string.
        /// </summary>
        [DataMember]
        [MessagePack.Key(200)]
        public string Username { get; set; }

        /// <summary>
        /// Return disabled operators.
        /// </summary>
        [DataMember]
        [MessagePack.Key(201)]
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// Return deleted operators.
        /// </summary>
        [DataMember]
        [MessagePack.Key(202)]
        public bool? IsDeleted { get; set; }

    }
}
