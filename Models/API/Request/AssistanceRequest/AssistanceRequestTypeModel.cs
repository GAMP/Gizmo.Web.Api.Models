using System;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Assistance request type.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class AssistanceRequestTypeModel : IAssistanceRequestTypeModel, IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id {get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public string Title {get;set; } = string.Empty;

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public int DisplayOrder { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public bool IsDeleted { get; set; }
    }
}
