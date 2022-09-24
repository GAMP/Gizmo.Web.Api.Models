using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User group disallowed host group.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class UserGroupDisallowedHostGroup : UserGroupDisallowedHostGroupModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the user group.
        /// </summary>
        [Key(101)]
        public int UserGroupId { get; set; }

        #endregion
    }
}