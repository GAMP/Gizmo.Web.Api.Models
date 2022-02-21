using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Pagination metadata.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class PaginationMetadata
    {
        /// <summary>
        /// The id of the record to be used as a cursor to get the next page.
        /// </summary>
        [DataMember]
        public int NextCursor { get; set; }

        /// <summary>
        /// The id of the record to be used as a cursor to get the previous page.
        /// </summary>
        [DataMember]
        public int PreviousCursor { get; set; }
    }
}