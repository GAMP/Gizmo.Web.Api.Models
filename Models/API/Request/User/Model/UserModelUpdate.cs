using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.User.Model
{
    /// <summary>
    /// User.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class UserModelUpdate : UserModelBase, IApiModelIdentifier, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Required]
        [MessagePack.Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The new password for the user, if left empty the password will remain the same.
        /// </summary>
        [StringLength(24)]
        [MessagePack.Key(101)]
        public string Password { get; set; }

        #endregion
    }
}
