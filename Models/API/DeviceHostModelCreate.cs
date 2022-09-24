using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Device host relation model.
    /// </summary>
    [Serializable()]
    [MessagePackObject()]
    public class DeviceHostModelCreate : DeviceHostModelBase
    {
    }
}