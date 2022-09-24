using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class User : UserModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The GUID of the user.
        /// </summary>
        [Key(101)]
        public Guid Guid { get; set; }

        /// <summary>
        /// Whether the user is guest.
        /// </summary>
        [Key(102)]
        public bool IsGuest { get; set; }

        #endregion
    }
}
