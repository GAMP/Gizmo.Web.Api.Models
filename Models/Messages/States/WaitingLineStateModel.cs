using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Waiting line state model.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public class WaitingLineStateModel
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets host group id.
        /// </summary>
        [DataMember()]
        [Key(0)]
        public int HostGroupId
        {
            get; init;
        }

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [Key(1)]
        public int UserId
        {
            get; init;
        }

        /// <summary>
        /// Gets or sets estimated host id.
        /// </summary>
        [DataMember()]
        [Key(2)]
        public int? EstimatedHostId
        {
            get; init;
        }

        /// <summary>
        /// Gets or sets estimated time.
        /// </summary>
        [DataMember()]
        [Key(3)]
        public double? EstimatedWaitTime
        {
            get; init;
        }

        /// <summary>
        /// Gets or sets state.
        /// </summary>
        [DataMember()]
        [Key(4)]
        public WaitingLineState State
        {
            get; init;
        }

        /// <summary>
        /// Gets or sets position.
        /// </summary>
        [DataMember()]
        [Key(5)]
        public int Position
        {
            get; init;
        }

        /// <summary>
        /// Gets or sets if position is manually set.
        /// </summary>
        [DataMember()]
        [Key(6)]
        public bool IsManualPosition
        {
            get; init;
        }

        /// <summary>
        /// Gets total time in waiting line.
        /// </summary>
        [DataMember()]
        [Key(7)]
        public double TimeInLine
        {
            get; init;
        }

        /// <summary>
        /// Gets ready time.
        /// </summary>
        [DataMember()]
        [Key(8)]
        public double ReadyTime
        {
            get; init;
        }

        /// <summary>
        /// Gets if ready timed out.
        /// </summary>
        [DataMember()]
        [Key(9)]
        public bool IsReadyTimedOut
        {
            get; init;
        }

        /// <summary>
        /// Gets or sets entry id.
        /// </summary>
        [DataMember()]  
        [Key(10)]
        public int EntryId
        {
            get; init;
        }

        /// <summary>
        /// Gets or sets created time.
        /// </summary>
        [DataMember()]
        [Key(11)]
        public DateTime CreatedTime
        {
            get; init;
        }

        #endregion
    }
}
