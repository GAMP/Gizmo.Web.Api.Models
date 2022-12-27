using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Application.License
{
    /// <summary>
    /// Application license.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationLicenseModelCreate : IApplicationLicenseApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the license.
        /// </summary>
        [MessagePack.Key(0)]
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// The plugin type name of the license.
        /// </summary>
        [MessagePack.Key(1)]
        [Required]
        [StringLength(255)]
        public string Plugin { get; set; }

        /// <summary>
        /// The plugin assembly of the license.
        /// </summary>        
        [MessagePack.Key(2)]
        [Required]
        [StringLength(255)]
        public string Assembly { get; set; }

        #endregion
    }
}
