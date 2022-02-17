using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User picture changed event message.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public class UserPictureChangedEventMessage : UserEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserPictureChangedEventMessage() : base()
        { } 
        #endregion
    }
}
