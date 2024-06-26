using System;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User hard delete filter model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserModelHardDelete : IWebApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// The id of the user to hard delete.
        /// </summary>
        [Key(0)]
        public int? UserId { get; set; }

        /// <summary>
        /// Keep user statistics.
        /// </summary>
        [Key(1)]
        public bool KeepStatistics { get; set; } = true;

        /// <summary>
        /// Delete all user data with 'IsDeleted' flag.
        /// </summary>
        [Key(2)]
        public bool? IsSoftDeleted { get; set; }

        #endregion
    }
}
