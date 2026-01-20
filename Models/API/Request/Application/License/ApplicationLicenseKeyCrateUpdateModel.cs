using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application license key crate update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ApplicationLicenseKeyCrateUpdateModel : IWebApiModel
    {
        /// <summary>
        /// License key id.
        /// </summary>
        /// <remarks>Null in case of a new license key.</remarks>
        [MessagePack.Key(0)]
        public int? Id { get; init; }

        /// <summary>
        /// Optional assigned host id.
        /// </summary>
        [MessagePack.Key(1)]
        public int? HostId { get;init; }

        /// <summary>
        /// Is enabled.
        /// </summary>
        [MessagePack.Key(2)]
        public bool IsEnabled { get; init; }

        /// <summary>
        /// Comment.
        /// </summary>
        [MessagePack.Key(3)]
        public string? Comment { get; init; }

        /// <summary>
        /// Key values.
        /// </summary>
        [MessagePack.Key(4)]
        public required IEnumerable<ApplicationLicenseKeyValueModel> Values { get; init; }
    }
}
