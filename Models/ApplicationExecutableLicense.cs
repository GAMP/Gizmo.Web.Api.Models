using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable license.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationExecutableLicense : ApplicationExecutableLicenseModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the executable this license is associated with.
        /// </summary>
        [DataMember]
        public int ApplicationExecutableId { get; set; }

        #endregion
    }
}