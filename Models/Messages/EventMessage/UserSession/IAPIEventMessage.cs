namespace Gizmo.Web.Api.Messaging
{
    [MessagePack.Union(1800, typeof(UserSessionCreatedEventMessage))]
    [MessagePack.Union(1801, typeof(UserSessionChangedEventMessage))]
    [MessagePack.Union(1802, typeof(UserSessionMovedEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
