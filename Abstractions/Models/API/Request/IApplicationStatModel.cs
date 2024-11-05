using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Application stat model.
    /// </summary>
    public interface IApplicationStatModel : IWebApiModel
    {
        /// <summary>
        /// User id.
        /// </summary>
        int UserId { get; init; }

        /// <summary>
        /// Host id.
        /// </summary>
        int HostId { get; init; }
        
        /// <summary>
        /// Application id.
        /// </summary>
        int AppId { get; init; }

        /// <summary>
        /// Application executable id.
        /// </summary>
        int AppExeId { get; init; }
        
        /// <summary>
        /// Start time.
        /// </summary>
        DateTime StartTime { get; init; }

        /// <summary>
        /// Span.
        /// </summary>
        double Span { get; init; }
    }
}
