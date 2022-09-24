using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application deployment.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationDeploymentModelCreate : ApplicationDeploymentModelBase
    {
    }
}
