using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for user notes.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class UserNotesFilter : PaginationFilter, IUrlQueryParameters
    {
    }
}
