using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable deployment.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationExecutableDeploymentModelCreate : ApplicationExecutableDeploymentModelBase
    {
    }
}
