using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User balance close event message.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public class UserBalanceCloseEventMessage : UserEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserBalanceCloseEventMessage():base()
        { }
        #endregion
    }
}
