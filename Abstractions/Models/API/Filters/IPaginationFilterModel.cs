namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Filters
{
    public interface IPaginationFilterModel : IGetOptionsFilterModel
    {
        int? StartingAfter { get; set; }
        int? EndingBefore { get; set; }
        int Limit { get; set; }
    }
}