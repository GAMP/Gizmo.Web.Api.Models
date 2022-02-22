using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for monetary units.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class MonetaryUnitsFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// Return deleted monetary units.
        /// </summary>
        [DataMember]
        [MessagePack.Key(200)]
        public bool? IsDeleted { get; set; }

        #endregion
    }
}