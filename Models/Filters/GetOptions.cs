using MessagePack;
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
    [MessagePackObject]
    public class GetOptions : IUrlQueryParameters
    {
        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [DataMember]
        [MessagePack.Key(0)]
        public List<string> Expand { get; set; }
    }
}