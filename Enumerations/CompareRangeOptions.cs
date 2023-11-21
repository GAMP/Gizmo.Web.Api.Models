namespace Gizmo.Web.Api.Models
{
    public enum CompareRangeOptions
    {
        None = 0,
        IsEqualTo = 1,
        IsGreaterThan = 2,
        IsGreaterThanOrEqualTo = 4,
        IsLessThan = 8,
        IsLessThanOrEqualTo = 16,
        IsBetween = 32
    }
}
