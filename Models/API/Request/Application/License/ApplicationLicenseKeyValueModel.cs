namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Property key value model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ApplicationLicenseKeyValueModel : IWebApiModel
    {
        /// <summary>
        /// Property name.
        /// </summary>
        [MessagePack.Key(0)]
        public required string PropertyName { get; init; }

        /// <summary>
        /// Property value.
        /// </summary>
        [MessagePack.Key(1)]
        public required string PropertyValue { get; init; }
    }
}
