using System;
using System.Collections.Generic;
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
        public List<string> Expand { get; set; }
    }
}