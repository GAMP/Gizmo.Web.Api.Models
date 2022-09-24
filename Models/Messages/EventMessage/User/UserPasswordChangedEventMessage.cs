using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User password changed event message.
    /// </summary>
    [MessagePackObject()]
    public class UserPasswordChangedEventMessage : UserEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserPasswordChangedEventMessage() : base()
        { } 
        #endregion
    }
}
