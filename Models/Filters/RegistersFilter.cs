using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for registers.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class RegistersFilter : PaginationFilter, IUrlQueryParameters
    {
    }
}
