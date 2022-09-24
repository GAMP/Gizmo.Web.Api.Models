using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class UserModelCreate : UserModelBase, IUrlQueryParameters
    {
        #region PROPERTIES
        
        /// <summary>
        /// The initial password for the user, if left empty no password will be set.
        /// </summary>
        [StringLength(24)]
        [MessagePack.Key(100)]
        public string Password { get; set; } 

        #endregion
    }
}
