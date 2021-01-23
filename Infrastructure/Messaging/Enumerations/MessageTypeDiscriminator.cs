namespace Gizmo.Web.Api.Messaging
{
    ///<inheritdoc/>
    public enum MessageTypeDiscriminator
    {
        /// <summary>
        /// Command message.
        /// </summary>
        Command = 0,

        /// <summary>
        /// Detailed message.
        /// </summary>
        Data = 1,

        /// <summary>
        /// Control message.
        /// </summary>
        Control = 2,
    }
}
