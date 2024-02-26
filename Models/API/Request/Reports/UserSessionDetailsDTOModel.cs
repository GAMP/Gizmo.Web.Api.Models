using System;
using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User Session Details.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class UserSessionDetailsDTOModel
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

        /// <summary>
        /// The name of the user to which the session belongs.
        /// </summary>
        [MessagePack.Key(12)]
        public string? UserName { get; set; }

        /// <summary>
        /// The name of the host on which the user session ran.
        /// </summary>
        [MessagePack.Key(13)]
        public string? HostName { get; set; }

        /// <summary>
        /// The number of the host on which the user session ran.
        /// </summary>
        [MessagePack.Key(14)]
        public int HostNumber { get; set; }

        /// <summary>
        /// The Id of the operator that started the session.
        /// </summary>
        [MessagePack.Key(15)]
        public int? LoginOperatorId { get; set; }

        /// <summary>
        /// The name of the operator that started the session.
        /// </summary>
        [MessagePack.Key(16)]
        public string? LoginOperatorName { get; set; }

        /// <summary>
        /// The Id of the operator that ended the session.
        /// </summary>
        [MessagePack.Key(17)]
        public int? LogoutOperatorId { get; set; }

        /// <summary>
        /// The name of the operator that ended the session.
        /// </summary>
        [MessagePack.Key(18)]
        public string? LogoutOperatorName { get; set; }

        /// <summary>
        /// The name of the host to which the session was moved.
        /// </summary>
        [MessagePack.Key(19)]
        public string? MoveHostName { get; set; }

        /// <summary>
        /// The state of the session.
        /// </summary>
        [MessagePack.Key(20)]
        public SessionState State { get; set; }
    }
}
