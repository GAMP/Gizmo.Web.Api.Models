using MessagePack;
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
    [MessagePackObject]
    public class UserModelUpdate : UserModelBase, IEntityBase, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The new password for the user, if left empty the password will remain the same.
        /// </summary>
        [DataMember]
        [StringLength(24)]
        [MessagePack.Key(101)]
        public string Password { get; set; }

        #endregion
    }
}
