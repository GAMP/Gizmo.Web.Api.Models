using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host endpoint.
    /// </summary>
    [Serializable]
    [DataContract]
    public class HostEndpoint
    {
        #region PROPERTIES

        [DataMember]
        [Required]
        public int MaximumUsers { get; set; }

        #endregion
    }
}
