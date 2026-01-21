using Gizmo.Web.Api.Models.Abstractions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application license.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class ApplicationLicenseModelUpdate : IWebApiModel, IModelIntIdentifier
    {
        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The name of the license.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(255)]
        [Required()]
        public required string Name { get; set; }

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
