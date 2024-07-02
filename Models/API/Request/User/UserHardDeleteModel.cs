using System;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User  information to hard delete.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserHardDeleteModel : IWebApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// The id of the user.
        /// </summary>
        [Key(0)]
        public int UserId { get; set; }

        #endregion
    }
}
