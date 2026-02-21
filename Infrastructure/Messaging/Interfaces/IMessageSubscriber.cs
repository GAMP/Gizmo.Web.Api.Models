using System;
using System.Threading;
using System.Threading.Tasks;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Provides plugins with access to the server's real-time event message stream.
    /// </summary>
    /// <remarks>
    /// Each call to <see cref="Observe{TMessage}"/> creates an independent, buffered subscription.
    /// Dispose the returned <see cref="IDisposable"/> (or subscription) to release resources.
    /// Slow subscribers will not block the server message pump — messages are dropped according
    /// to the configured <see cref="MessageSubscriptionOptions.FullMode"/> when the buffer is full.
    /// </remarks>
    public interface IMessageSubscriber
    {
        /// <summary>
        /// Creates a typed observable for a specific event message type.
        /// </summary>
        /// <typeparam name="TMessage">
        /// The event message type to observe. Specify a base type to receive all derived messages.
        /// </typeparam>
        /// <param name="options">
        /// Buffer options for this subscription. When <see langword="null"/>, defaults are applied
        /// (buffer size 100, <see cref="System.Threading.Channels.BoundedChannelFullMode.DropOldest"/>).
        /// </param>
        /// <returns>A hot observable that emits matching messages as they arrive.</returns>
        IObservable<TMessage> Observe<TMessage>(MessageSubscriptionOptions? options = null)
            where TMessage : IAPIEventMessage;

        /// <summary>
        /// Subscribes to a specific event message type with a synchronous callback.
        /// </summary>
        /// <typeparam name="TMessage">The event message type.</typeparam>
        /// <param name="handler">Callback invoked for each matching message. Must be fast and non-blocking.</param>
        /// <param name="options">Buffer options for this subscription.</param>
        /// <returns>Subscription handle — dispose to unsubscribe.</returns>
        IDisposable Subscribe<TMessage>(Action<TMessage> handler, MessageSubscriptionOptions? options = null)
            where TMessage : IAPIEventMessage
            => Observe<TMessage>(options).Subscribe(new ActionObserver<TMessage>(handler));

        private sealed class ActionObserver<T> : IObserver<T>
        {
            private readonly Action<T> _onNext;
            public ActionObserver(Action<T> onNext) => _onNext = onNext;
            public void OnNext(T value) => _onNext(value);
            public void OnError(Exception error) { }
            public void OnCompleted() { }
        }

        /// <summary>
        /// Asynchronously waits for the next occurrence of a specific event message type.
        /// </summary>
        /// <typeparam name="TMessage">The event message type.</typeparam>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The first matching message received.</returns>
        /// <exception cref="OperationCanceledException">
        /// Thrown when <paramref name="cancellationToken"/> is cancelled.
        /// </exception>
        Task<TMessage> WaitForAsync<TMessage>(CancellationToken cancellationToken = default)
            where TMessage : IAPIEventMessage
            => WaitForAsync<TMessage>(Timeout.InfiniteTimeSpan, cancellationToken);

        /// <summary>
        /// Asynchronously waits for the next occurrence of a specific event message type,
        /// with an optional timeout.
        /// </summary>
        /// <typeparam name="TMessage">The event message type.</typeparam>
        /// <param name="timeout">
        /// Maximum time to wait. Use <see cref="Timeout.InfiniteTimeSpan"/> for no timeout.
        /// </param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The first matching message received.</returns>
        /// <exception cref="OperationCanceledException">
        /// Thrown when <paramref name="cancellationToken"/> is cancelled.
        /// </exception>
        /// <exception cref="TimeoutException">
        /// Thrown when <paramref name="timeout"/> elapses before a matching message arrives.
        /// </exception>
        Task<TMessage> WaitForAsync<TMessage>(TimeSpan timeout, CancellationToken cancellationToken = default)
            where TMessage : IAPIEventMessage;
    }
}
