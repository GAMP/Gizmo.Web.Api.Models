using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable license.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationExecutableLicenseModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the license associated with this application executable.
        /// </summary>
        [Required]
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