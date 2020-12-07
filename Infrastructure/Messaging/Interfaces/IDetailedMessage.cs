using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Generic detailed message interface.
    /// </summary>
    [Union(0, typeof(DetailedMessage))]
    public interface IDetailedMessage : IMessage
    {
        #region PROPERTIES

        /// <summary>
        /// Message detail.
        /// </summary>
        IMessageDetail Detail { get; }

        #endregion
    }
}
