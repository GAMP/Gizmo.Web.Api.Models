namespace Gizmo.Web.Api.Messaging
{
    [MessagePack.Union(1800, typeof(UserSessionCreatedEventMessage))]
    [MessagePack.Union(1801, typeof(UserSessionMovedEventMessage))]
    [MessagePack.Union(1802, typeof(UserSessionStateChangedEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
