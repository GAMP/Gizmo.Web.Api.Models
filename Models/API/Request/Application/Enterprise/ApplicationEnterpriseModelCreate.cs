using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application enterprise.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationEnterpriseModelCreate : IApplicationEnterpriseApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the enterprise.
        /// </summary>
        [MessagePack.Key(0)]
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        #endregion
    }
}
