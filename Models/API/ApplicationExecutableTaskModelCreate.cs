using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable task.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationExecutableTaskModelCreate : ApplicationExecutableTaskModelBase
    {
    }
}
