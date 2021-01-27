using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application group application.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationGroupApplication : ApplicationGroupApplicationModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// Gets
        /// </summary>
        [DataMember]
        public int ApplicationGroupId { get; set; }

        #endregion
    }
}
