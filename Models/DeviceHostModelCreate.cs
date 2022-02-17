using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Device host relation model.
    /// </summary>
    [Serializable()]
    [DataContract]
    [MessagePackObject()]
    public class DeviceHostModelCreate : DeviceHostModelBase
    {
    }
}