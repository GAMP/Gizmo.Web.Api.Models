using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User.
    /// </summary>
    [DataContract]
    [Serializable]
    public class UserModelCreate : UserModelBase, IUrlQueryParameters
    {
        /// <summary>
        /// The initial password for the user, if left empty no password will be set.
        /// </summary>
        [DataMember]
        [StringLength(24)]
        public string Password { get; set; }
    }
}
