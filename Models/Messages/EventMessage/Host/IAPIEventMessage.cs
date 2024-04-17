namespace Gizmo.Web.Api.Messaging
{
    [MessagePack.Union(800, typeof(HostInOrderStateChanged))]
    [MessagePack.Union(801, typeof(HostLockStateChanged))]
    public partial interface IAPIEventMessage
    {
    }
}
