using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    [Serializable]
    [DataContract]
    public class PagedList<T>
    {
        public PagedList(IEnumerable<T> data, PaginationMetadata meta)
        {
            Data = data;
            Meta = meta;
        }

        [DataMember]
        public IEnumerable<T> Data { get; }

        [DataMember]
        public PaginationMetadata Meta { get; }
    }
}