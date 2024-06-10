using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Active waiting line entry model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class WaitingLineEntryActiveModel : IWebApiModel , IModelIntIdentifier
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id
        {
            get; init;
        }

        /// <summary>
        /// Waiting line host group id.
        /// </summary>
        [MessagePack.Key(1)]
        public int HostGroupId
        {
            get; init;
        }

        /// <summary>
        /// User id.
        /// </summary>
        [MessagePack.Key(2)]
        public int UserId
        {
            get; init;
        }

        /// <summary>
        /// User group id.
        /// </summary>
        [MessagePack.Key(3)]
        public int UserGroupId
        {
            get; init;
        }

        /// <summary>
        /// Position in line.
        /// </summary>
        [MessagePack.Key(4)]
        public int Position
        {
            get; init;
        }

        /// <summary>
        /// Manual position.
        /// </summary>
        [MessagePack.Key(5)]
        public bool IsManualPosition
        {
            get; init;
        }

        /// <summary>
        /// Total time in line.
        /// </summary>
        [MessagePack.Key(6)]
        public double TimeInLine
        {
            get; init;
        }

        /// <summary>
        /// Ready timeout time.
        /// </summary>
        [MessagePack.Key(7)]
        public double ReadyTime
        {
            get; init;
        }

        /// <summary>
        /// Indicates ready timeout.
        /// </summary>
        [MessagePack.Key(8)]
        public bool IsReadyTimedOut
        {
            get; init;
        }

        /// <summary>
        /// Estimated host id.
        /// </summary>
        [MessagePack.Key(9)]
        public int? EstimatedHostId
        {
            get; init;
        }

        /// <summary>
        /// Estimated wait time.
        /// </summary>
        [MessagePack.Key(10)]
        public double? EstimatedWaitTime
        {
            get; init;
        }
    }
}
