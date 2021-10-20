using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for devices.
    /// </summary>
    [Serializable]
    [DataContract]
    public class DevicesFilter : PaginationFilter, IUrlQueryParameters
    {
    }
}
