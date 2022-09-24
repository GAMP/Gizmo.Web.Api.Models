using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationExecutableModelCreate : ApplicationExecutableModelBase, IUrlQueryParameters
    {
    }
}
