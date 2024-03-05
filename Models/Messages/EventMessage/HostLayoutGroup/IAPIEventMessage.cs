namespace Gizmo.Web.Api.Messaging
{
    [MessagePack.Union(1500,typeof(HostLayoutGroupCreatedEventMessage))]
    [MessagePack.Union(1501, typeof(HostLayoutGroupUpdatedEventMessage))]
    [MessagePack.Union(1502, typeof(HostLayoutGroupRemovedEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
