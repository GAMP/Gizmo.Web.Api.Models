using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Range filter.
    /// </summary>
    public interface IModelFilterRange
    {
        /// <summary>
        /// Return data where the date greater than or equal to the specified date.
        /// </summary>
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return data where the date less than or equal to the specified date.
        /// </summary>
        public DateTime? DateTo { get; set; }

    }
}
