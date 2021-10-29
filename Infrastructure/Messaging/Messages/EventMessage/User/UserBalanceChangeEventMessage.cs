using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User balance changed event message.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public class UserBalanceChangeEventMessage : UserEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserBalanceChangeEventMessage() : base()
        { }
        #endregion
    }
}
