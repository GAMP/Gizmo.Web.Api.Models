using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Shift model.
    /// </summary>
    public interface IShiftModel : IWebApiModel
    {
        /// <summary>
        /// Operator id.
        /// </summary>
        int OperatorId { get; }

        /// <summary>
        /// Register id.
        /// </summary>
        int RegisterId { get; }

        /// <summary>
        /// Is active.
        /// </summary>
        bool IsActive { get; }

        /// <summary>
        /// Is ending.
        /// </summary>
        bool IsEnding { get; }

        /// <summary>
        /// Start time.
        /// </summary>
        DateTime StartTime { get; }

        /// <summary>
        /// End time.
        /// </summary>
        DateTime? EndTime { get; }

        /// <summary>
        /// Start cash.
        /// </summary>
        decimal StartCash { get; }
    }
}
