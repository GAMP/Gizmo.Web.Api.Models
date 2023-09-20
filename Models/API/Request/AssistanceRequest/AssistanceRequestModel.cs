using System;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Assistance request.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class AssistanceRequestModel : IAssistanceRequestModel, IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public int AssistanceRequestTypeId { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public int? UserId { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public int HostId { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public AssistanceRequestStatus Status { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(5)]
        public string? Note { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(6)]
        public DateTime CreatedTime { get; set; }
    }
}
