using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application license.
    /// </summary>
    [MessagePack.MessagePackObject]
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
        /// License options.
        /// </summary>
        [MessagePack.Key(2)]
        public required IEnumerable<ApplicationLicenseKeyCrateUpdateModel> Options { get; init; }

        /// <summary>
        /// License keys.
        /// </summary>
        [MessagePack.Key(3)]
        public required IEnumerable<ApplicationLicenseKeyCrateUpdateModel> Keys { get; init; }
    }
}
