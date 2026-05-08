using System;
using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User maintenance process result event message base class.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("User maintenance process result")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("User maintenance process result event message base class")]
    [EventGroup(25)]
    public abstract class UserMaintenanceResultEventMessageBase : APIEventMessage
    {
        /// <summary>
        /// Background process identifier.
        /// </summary>
        [Key(1)]
        public Guid ProcessId { get; init; }
        
        /// <summary>
        /// Process state.
        /// </summary>
        [Key(2)]
        public required ProcessState ProcessState { get; init; }

        /// <summary>
        /// Process creation time.
        /// </summary>
        [Key(3)]
        public DateTime CreatedTime { get; init; }

        /// <summary>
        /// Process completion time.
        /// </summary>
        [Key(4)]
        public DateTime? CompletedTime { get; init; }
    }

    /// <summary>
    /// User maintenance process state.
    /// </summary>
    public enum ProcessState
    {
        /// <summary>Pending state.</summary>
        Pending = 0,
        /// <summary>Processing state.</summary>
        Processing = 1,
        /// <summary>Completed state.</summary>
        Completed = 2,
        /// <summary>Failed state.</summary>
        Failed = 3
    }
}
