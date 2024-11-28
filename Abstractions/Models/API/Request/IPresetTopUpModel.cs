namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Preset top up model.
    /// </summary>
    public interface IPresetTopUpModel : IWebApiModel
    {
        /// <summary>
        /// Gets or sets the display order.
        /// </summary>
        int DisplayOrder { get; init; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        decimal Value { get; init; }
    }
}
