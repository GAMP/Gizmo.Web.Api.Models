using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User smart card change event message.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public class UserSmartCardChangeEventMessage : UserEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserSmartCardChangeEventMessage() : base()
        { } 
        #endregion
    }
}
