namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Plugin library update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PluginLibraryModelUpdate
    {
        [MessagePack.Key(0)]
        public int Id { get; init; }

        [MessagePack.Key(1)]
        public bool IsEnabled { get; init; }

        [MessagePack.Key(2)]
        public bool AvailableInServer { get; init; }

        [MessagePack.Key(3)]
        public bool AvailableInClient { get; init; }

        [MessagePack.Key(4)]
        public bool AvailableInManager { get; init; }
    }
}
