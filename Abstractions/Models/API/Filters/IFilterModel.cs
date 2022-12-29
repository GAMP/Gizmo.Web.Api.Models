namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Filters
{
    /// <summary>
    /// Filter.
    /// </summary>
    public interface IFilterModel : IPaginationFilterModel, IGetOptionsFilterModel, IUrlQueryParameters
    {
    }
}