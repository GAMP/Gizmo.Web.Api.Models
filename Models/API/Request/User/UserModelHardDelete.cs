using System;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User Ids to hard delete.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserModelHardDelete : IWebApiModel
    {
        /// <summary>
        /// The ids of the users to hard delete.
        /// </summary>
        [Key(0)]
        public int[] UserIds { get; set; } = [];
    }
}
