using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable image.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationExecutableImage : ImageModelBase
    {
    }
}