using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable task.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationExecutableTaskModelCreate : ApplicationExecutableTaskModelBase
    {
    }
}
