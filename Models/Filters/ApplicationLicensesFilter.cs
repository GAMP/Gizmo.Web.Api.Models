﻿using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions.Models.API.Filters;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for application licenses.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationLicensesFilter : IFilterModel
    {
        #region PROPERTIES

        /// <summary>
        /// Filter for cursor-based pagination.
        /// </summary>
        [Key(0)]
        public PaginationFilter PaginationFilter { get; set; }

        /// <summary>
        /// Return licenses with names that contain the specified string.
        /// </summary>
        [Key(1)]
        public string LicenseName { get; set; }

        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [Key(2)]
        public List<string> Expand { get; set; }

        #endregion
    }
}
