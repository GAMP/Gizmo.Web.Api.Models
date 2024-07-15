﻿namespace Gizmo.Web.Api.Messaging
{
    [MessagePack.Union(1700, typeof(HostComputerMaintenanceChanged))]
    [MessagePack.Union(1701, typeof(HostComputerSecurityChanged))]
    [MessagePack.Union(1702, typeof(HostComputerInputLockChanged))]
    [MessagePack.Union(1703, typeof(HostComputerConnectionChangedEventMessage))]
    [MessagePack.Union(1704, typeof(HostComputerClientModuleVersionChanged))]
    public partial interface IAPIEventMessage
    {
    }
}
