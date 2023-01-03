namespace Gizmo.Web.Api.Models.Abstractions.Models.Filters
{
    /// <summary>
    /// Filter.
    /// </summary>
    public interface IFilterApiModel : IPaginationFilterModel, IGetOptionsFilterModel, IUrlQueryParameters
    {
    }
}