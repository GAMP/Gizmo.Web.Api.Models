using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for registers.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class RegistersFilter : PaginationFilter, IUrlQueryParameters
    {
    }
}
