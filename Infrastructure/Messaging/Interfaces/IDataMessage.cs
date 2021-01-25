namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Data message interface.
    /// </summary>
    public interface IDataMessage : IMessage
    {
        #region PROPERTIES

        /// <summary>
        /// Message detail.
        /// </summary>
        IMessageDetail Detail { get; }

        #endregion
    }
}
