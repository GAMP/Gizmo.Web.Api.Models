using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Range filter.
    /// </summary>
    public interface IModelFilterRange
    {
        /// <summary>
        /// Date compare option.
        /// </summary>
        public CompareRangeOptions? DateCompareOption { get; set; }

        /// <summary>
        /// Return data where the date greater than or equal to the specified date.
        /// </summary>
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return data where the date less than or equal to the specified date.
        /// </summary>
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Message type.
        /// </summary>
        public LogMessageType? MessageType { get; set; }

        /// <summary>
        /// Module type.
        /// </summary>
        public ModuleType? ModuleType { get; set; }

        /// <summary>
        /// Message compare option.
        /// </summary>
        public CompareStringOptions? MessageCompareOption { get; set; }

        /// <summary>
        /// Filter data based on message compare option and message pattern.
        /// </summary>
        public string? Message { get; set; }
    }
}
