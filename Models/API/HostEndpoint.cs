using MessagePack;
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
    [MessagePackObject]
    public class HostEndpoint
    {
        #region PROPERTIES

        /// <summary>
        /// The maximum number of users the endpoint can host.
        /// </summary>
        [DataMember]
        [Required]
        public int MaximumUsers { get; set; }

        #endregion
    }
}
