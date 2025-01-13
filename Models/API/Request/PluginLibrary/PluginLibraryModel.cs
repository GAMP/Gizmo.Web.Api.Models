namespace Gizmo.Web.Api.Models
{
    [MessagePack.MessagePackObject()]
    public sealed class PluginLibraryModel : IWebApiModel
    {
        [MessagePack.Key(0)]
        public int Id { get; init; }

        [MessagePack.Key(1)]
        public string FileName { get; init; }

        [MessagePack.Key(2)]
        public bool IsEnabled { get; init; }

        [MessagePack.Key(3)]
        public bool AvailableInServer { get; init; }

        [MessagePack.Key(4)]
        public bool AvailableInClient { get; init; }

        [MessagePack.Key(5)]
        public bool AvailableInManager { get; init; }
    }
}
