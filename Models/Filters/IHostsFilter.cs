using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    public interface IHostsFilter
    {
        List<string> Expand { get; set; }
        [StringLength(2)]
        string HostName { get; set; }
        bool? IsDeleted { get; set; }
        PaginationFilter PaginationFilter { get; set; }
    }
}