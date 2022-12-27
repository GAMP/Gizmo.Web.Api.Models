using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;

namespace Gizmo.Web.Api.Models.Models.API.Request.Application.Executable.License
{
    /// <summary>
    /// Application executable license.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationExecutableLicenseModelCreate : IApplicationExecutableLicenseApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the license associated with this application executable.
        /// </summary>
        [MessagePack.Key(0)]
        public int LicenseId { get; set; }

        /// <summary>
        /// The order in which the license is used.
        /// </summary>
        [MessagePack.Key(1)]
        public int UseOrder { get; set; }

        #endregion
    }
}
