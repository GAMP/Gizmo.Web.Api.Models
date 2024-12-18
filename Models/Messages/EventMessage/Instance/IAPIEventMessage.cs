namespace Gizmo.Web.Api.Messaging
{
    [MessagePack.Union(2200, typeof(InstanceAuthenticationChangedEventMessage))]
    [MessagePack.Union(2201, typeof(InstanceAuthorizationChangedEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
