using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationExecutableModelCreate : ApplicationExecutableModelBase, IUrlQueryParameters
    {
    }
}
