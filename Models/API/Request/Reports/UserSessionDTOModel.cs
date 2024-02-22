using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User Session Information.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class UserSessionDTOModel
    {
        /// <summary>
        /// User Session Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The time the session started.
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// The time the session ended, null if still active.
        /// </summary>
        [MessagePack.Key(2)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Duration of the user session in seconds.
        /// </summary>
        [MessagePack.Key(3)]
        public double Span { get; set; }

        /// <summary>
        /// Billed seconds.
        /// </summary>
        [MessagePack.Key(4)]
        public double BilledSpan { get; set; }

        /// <summary>
        /// The Id of the user to which the session belongs.
        /// </summary>
        [MessagePack.Key(5)]
        public int UserId { get; set; }

        /// <summary>
        /// The Id of the group in which the user of the session belongs.
        /// </summary>
        [MessagePack.Key(6)]
        public int UserGroupId { get; set; }

        /// <summary>
        /// User is guest.
        /// </summary>
        [MessagePack.Key(7)]
        public bool UserIsGuest { get; set; }

        /// <summary>
        /// The Id of the host on which the user session ran.
        /// </summary>
        [MessagePack.Key(8)]
        public int HostId { get; set; }

        /// <summary>
        /// The slot number on which the user session ran.
        /// </summary>
        [MessagePack.Key(9)]
        public int Slot { get; set; }

        /// <summary>
        /// Duration of the user session in minutes.
        /// </summary>
        [MessagePack.Key(10)]
        public decimal TotalMinutes { get; set; }

        /// <summary>
        /// The time the session was running as text.
        /// </summary>
        [MessagePack.Key(11)]
        public string? Duration { get; set; }
    }
}
