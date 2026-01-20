using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application license key.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ApplicationLicenseKey : IWebApiModel, IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public required int Id { get; init; }

        /// <summary>
        /// Assigned host identifier.
        /// </summary>
        [MessagePack.Key(1)]
        public int? HostId { get; init; }

        /// <summary>
        /// Is enabled.
        /// </summary>
        [MessagePack.Key(2)]
        public bool IsEnabled { get; init; }

        /// <summary>
        /// Optional comment.
        /// </summary>
        [MessagePack.Key(3)]
        public string? Comment { get; init; }

        /// <summary>
        /// Display value.
        /// </summary>
        [MessagePack.Key(4)]
        public required string? DisplayValue { get; init; }

        /// <summary>
        /// Key value.
        /// </summary>
        /// <remarks>
        /// The value may be null when the key cant be deserialized.
        /// </remarks>
        [MessagePack.Key(5)]
        public required ApplicationLicenseKeyValueModel[] Values { get; init; }
    }
}
