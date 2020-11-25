using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    [Serializable]
    [DataContract]
    public class PaginationMetadata
    {
        [DataMember]
        public int NextCursor { get; set; }

        [DataMember]
        public int PreviousCursor { get; set; }
    }
}