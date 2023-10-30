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

        /// <summary>
        /// Log category.
        /// </summary>
        LogCategory Category { get; init; }

        /// <summary>
        /// Module type.
        /// </summary>
        ModuleType ModuleType { get;init; }

        /// <summary>
        /// Module version.
        /// </summary>
        string? ModuleVersion { get;init; }

        /// <summary>
        /// Log message type.
        /// </summary>
        LogMessageType MessageType { get;init; }
    }
}
