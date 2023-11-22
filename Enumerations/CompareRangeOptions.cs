namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Compare range options.
    /// </summary>
    public enum CompareRangeOptions
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Value is equal to the filter.
        /// </summary>
        IsEqualTo = 1,

        /// <summary>
        /// Value is greater then or equal to the filter.
        /// </summary>
        IsGreaterThanOrEqualTo = 2,

        /// <summary>
        /// Value is less then or equal to the filter.
        /// </summary>
        IsLessThanOrEqualTo = 4,

        /// <summary>
        /// Value is between the filters.
        /// </summary>
        IsBetween = 8
    }
}
