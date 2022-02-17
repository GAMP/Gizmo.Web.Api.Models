using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host icon.
    /// </summary>
    [DataContract]
    [Serializable]
    public class HostIconModelCreate : HostIconModelBase, IUrlQueryParameters
    {
    }
}
