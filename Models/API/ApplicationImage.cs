using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application image.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationImage : ImageModelBase
    {
    }
}