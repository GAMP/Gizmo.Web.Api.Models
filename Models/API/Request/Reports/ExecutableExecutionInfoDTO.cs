using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Executable Execution Information.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class ExecutableExecutionInfoDTO : ExecutableInfoDTO
    {
        /// <summary>
        /// The Id of the user that ran the executable.
        /// </summary>
        [MessagePack.Key(0)]
        public int UserId { get; set; }

        /// <summary>
        /// The Id of the user group to which the user belongs.
        /// </summary>
        [MessagePack.Key(1)]
        public int UserGroupId { get; set; }

        /// <summary>
        /// The Id of the host on which the executable ran.
        /// </summary>
        [MessagePack.Key(2)]
        public int HostId { get; set; }

        /// <summary>
        /// The Id of the host group to which the host belongs.
        /// </summary>
        [MessagePack.Key(3)]
        public int? HostGroupId { get; set; }

        /// <summary>
        /// The time the executable started.
        /// </summary>
        [MessagePack.Key(4)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// The time the executable ended.
        /// </summary>
        [MessagePack.Key(5)]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// The duration of the executable run in seconds.
        /// </summary>
        [MessagePack.Key(6)]
        public double Span { get; set; }

        /// <summary>
        /// The user that ran the application is guest.
        /// </summary>
        [MessagePack.Key(7)]
        public bool IsGuest { get; set; }

        /// <summary>
        /// User session information.
        /// </summary>
        [MessagePack.Key(8)]
        public UserSessionDTO UserSession { get; set; }
    }
}
