using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host endpoint.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class HostEndpoint
    {
        #region PROPERTIES

        /// <summary>
        /// The maximum number of users the endpoint can host.
        /// </summary>
        [Required]
        [MessagePack.Key(0)]
        public int MaximumUsers { get; set; }

        #endregion
    }
}
