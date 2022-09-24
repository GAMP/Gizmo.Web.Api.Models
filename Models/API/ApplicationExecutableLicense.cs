using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable license.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationExecutableLicense : ApplicationExecutableLicenseModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the application executable.
        /// </summary>
        [Key(100)]
        public int ApplicationExecutableId { get; set; }

        #endregion
    }
}