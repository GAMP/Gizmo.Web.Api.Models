using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Base filter for cursor-based pagination.
    /// </summary>
    [Serializable]
    [DataContract]
    public class GetOptions
    {
        /// <summary>
        /// Return records before the specified Id.
        /// </summary>
        [DataMember]
        public string[] Expand { get; set; }
    }
}