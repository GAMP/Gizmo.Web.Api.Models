using MessagePack;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        public string Name { get; set; } = null!;

        /// <summary>
        /// The plugin type name of the license.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(255)]
        [Required()]
        public string Plugin { get; set; } = null!;

        /// <summary>
        /// The plugin assembly of the license.
        /// </summary>
        [MessagePack.Key(2)]
        [StringLength(255)]
        [Required()]
        public string Assembly { get; set; } = null!;

        /// <summary>
        /// License keys.
        /// </summary>
        [MessagePack.Key(3)]
        public required IEnumerable< ApplicationLicenseKeyCrateUpdateModel> Keys { get; init; }
    }
}
