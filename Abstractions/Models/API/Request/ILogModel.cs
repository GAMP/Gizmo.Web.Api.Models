using System;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Log model.
    /// </summary>
    public interface ILogModel : IWebApiModel , IModelIntIdentifier
    {
        /// <summary>
        /// Host name.
        /// </summary>
        string? Hostname { get; init; }

        /// <summary>
        /// Host number.
        /// </summary>
        int? HostNumber { get; init; }

        /// <summary>
        /// Message.
        /// </summary>
        string Message { get; init; }

        /// <summary>
        /// Time.
        /// </summary>
        DateTime Time { get; init; }
    }
}
