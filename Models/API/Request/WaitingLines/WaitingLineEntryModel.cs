using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Waiting line entry model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class WaitingLineEntryModel : IWebApiModel
    {
        /// <summary>
        /// Waiting line host group id.
        /// </summary>
        [MessagePack.Key(0)]
        public int HostGroupId
        {
            get; init;
        }

        /// <summary>
        /// User id.
        /// </summary>
        [MessagePack.Key(1)]
        public int UserId
        {
            get; init;
        }

        /// <summary>
        /// Position in line.
        /// </summary>
        [MessagePack.Key(2)]
        public int Position
        {
            get; init;
        }

        /// <summary>
        /// Manual position.
        /// </summary>
        [MessagePack.Key(3)]
        public bool IsManualPosition
        {
            get; init;
        }

        /// <summary>
        /// Total time in line.
        /// </summary>
        [MessagePack.Key(4)]
        public TimeSpan TimeInLine
        {
            get; init;
        }

        /// <summary>
        /// Ready timeout time.
        /// </summary>
        [MessagePack.Key(5)]
        public TimeSpan ReadyTime
        {
            get; init;
        }

        /// <summary>
        /// Indicates ready timeout.
        /// </summary>
        [MessagePack.Key(6)]
        public bool IsReadyTimedOut
        {
            get; init;
        }

        /// <summary>
        /// Entry is active.
        /// </summary>
        [MessagePack.Key(7)]
        public bool IsActive
        {
            get; init;
        }

        /// <summary>
        /// Entry is processed.
        /// </summary>
        [MessagePack.Key(8)]
        public bool IsProcessed
        {
            get; init;
        }

        /// <summary>
        /// Entry cancelled.
        /// </summary>
        [MessagePack.Key(9)]
        public bool IsCancelled
        {
            get; init;
        }
    }
}
