using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Generic message interface.
    /// </summary>
    [Union(0, typeof(DetailedMessage))]
    [Union(1, typeof(CommandMessage))]
    public interface IMessage
    {
        #region PROPERTIES

        /// <summary>
        /// Gets message version.
        /// </summary>
        public int Version { get; }

        #endregion
    }
}
