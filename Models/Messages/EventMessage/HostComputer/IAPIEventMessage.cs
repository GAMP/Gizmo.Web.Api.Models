namespace Gizmo.Web.Api.Messaging
{
    [MessagePack.Union(1700, typeof(HostComputerMaintenanceChanged))]
    [MessagePack.Union(1701, typeof(HostComputerSecurityChanged))]
    [MessagePack.Union(1702, typeof(HostComputerInputLockChanged))]
    public partial interface IAPIEventMessage
    {
    }
}
