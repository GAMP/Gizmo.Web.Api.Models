using System.Threading.Channels;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Options controlling the per-subscriber message buffer for <see cref="IMessageSubscriber"/>.
    /// </summary>
    public sealed class MessageSubscriptionOptions
    {
        /// <summary>
        /// Gets the maximum number of messages to buffer for this subscriber before the
        /// <see cref="FullMode"/> policy is applied.
        /// </summary>
        /// <remarks>Default is 100.</remarks>
        public int BufferSize { get; init; } = 100;

        /// <summary>
        /// Gets the behaviour applied when the subscriber buffer reaches <see cref="BufferSize"/>.
        /// </summary>
        /// <remarks>
        /// Default is <see cref="BoundedChannelFullMode.DropOldest"/>.<br/>
        /// <b>Note:</b> <see cref="BoundedChannelFullMode.Wait"/> is not supported — because the
        /// underlying Subject dispatch is synchronous, a full buffer will always drop the incoming
        /// message rather than block. Use <see cref="BoundedChannelFullMode.DropOldest"/> or
        /// increase <see cref="BufferSize"/> if message loss is unacceptable.
        /// </remarks>
        public BoundedChannelFullMode FullMode { get; init; } = BoundedChannelFullMode.DropOldest;
    }
}
