using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application license.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationLicenseModelCreate : IWebApiModel
    {
        /// <summary>
        /// The name of the license.
        /// </summary>
        [MessagePack.Key(0)]
        [StringLength(255)]
        [Required()]
        public required string Name { get; set; }

        /// <summary>
        /// License plugin unique identifier.
        /// </summary>
        [MessagePack.Key(1)]
        public required Guid Plugin { get; set; }

        /// <summary>
        /// License keys.
        /// </summary>
        [MessagePack.Key(2)]
        public required IEnumerable<ApplicationLicenseKeyCrateUpdateModel> Keys { get; init; }
    }
}
