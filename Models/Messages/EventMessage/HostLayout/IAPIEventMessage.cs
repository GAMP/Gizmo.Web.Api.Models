namespace Gizmo.Web.Api.Messaging
{
    [MessagePack.Union(1400,typeof(HostLayoutCreatedEventMessage))]
    [MessagePack.Union(1401, typeof(HostLayoutUpdatedEventMessage))]
    [MessagePack.Union(1402, typeof(HostLayoutRemovedEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
