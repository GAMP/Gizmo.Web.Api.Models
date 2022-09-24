using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for monetary units.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class MonetaryUnitsFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// Return deleted monetary units.
        /// </summary>
        [Key(200)]
        public bool? IsDeleted { get; set; }

        #endregion
    }
}