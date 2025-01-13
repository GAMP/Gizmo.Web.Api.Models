using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Plugin library model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PluginLibraryModel : IWebApiModel , IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// File name.
        /// </summary>
        [MessagePack.Key(1)]
        public string FileName { get; init; } = null!;

        /// <summary>
        /// Indicates if enabled.
        /// </summary>
        [MessagePack.Key(2)]
        public bool IsEnabled { get; init; }

        /// <summary>
        /// Indicates server.
        /// </summary>
        [MessagePack.Key(3)]
        public bool AvailableInServer { get; init; }

        /// <summary>
        /// Indicates client.
        /// </summary>
        [MessagePack.Key(4)]
        public bool AvailableInClient { get; init; }

        /// <summary>
        /// Indicates manager.
        /// </summary>
        [MessagePack.Key(5)]
        public bool AvailableInManager { get; init; }
    }
}
