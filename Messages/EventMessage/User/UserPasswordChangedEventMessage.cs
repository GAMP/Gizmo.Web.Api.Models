using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User password changed event message.
    /// </summary>
    [DataContract()]
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
