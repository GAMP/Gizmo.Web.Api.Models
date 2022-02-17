using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application image.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationImage : ImageModelBase
    {
    }
}