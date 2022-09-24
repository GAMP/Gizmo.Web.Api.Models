using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable image.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationExecutableImage : ImageModelBase
    {
    }
}