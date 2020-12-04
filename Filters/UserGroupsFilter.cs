namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for user groups.
    /// </summary>
    public class UserGroupsFilter : PaginationFilter, IUrlQueryParameters
    {
        public string ToQueryParameters()
        {
            return ParameterGenerator.Generate(this);
        }
    }
}
