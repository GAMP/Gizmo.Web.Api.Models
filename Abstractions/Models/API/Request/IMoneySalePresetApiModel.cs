namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Request
{
    /// <summary>
    /// Money sale preset.
    /// </summary>
    public interface IMoneySalePresetApiModel
    {
        /// <summary>
        /// The display order of the money sale preset.
        /// </summary>
        int DisplayOrder { get; set; }

        /// <summary>
        /// The value of the money sale preset.
        /// </summary>
        decimal Value { get; set; }
    }
}