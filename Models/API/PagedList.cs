using MessagePack;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Paged list.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class PagedList<T>
    {
        public PagedList(IEnumerable<T> data, PaginationMetadata meta)
        {
            Data = data;
            Meta = meta;
        }

        /// <summary>
        /// The data of the current result set.
        /// </summary>
        [DataMember]
        public IEnumerable<T> Data { get; }

        /// <summary>
        /// The pagination metadata of the current result set.
        /// </summary>
        [DataMember]
        public PaginationMetadata Meta { get; }
    }
}