namespace Gizmo.Web.Api.Messaging
{
    ///<inheritdoc/>
    public enum MessageTypeDiscriminator 
    {
        Message = 0,
        /// <summary>
        /// Detailed message.
        /// </summary>
        DetailMessage = 1,

        /// <summary>
        /// Command message.
        /// </summary>
        CommandMessage=2,
    }
}
