using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User balance close event message.
    /// </summary>
    [MessagePackObject()]
    public class UserBalanceCloseEventMessage : UserEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserBalanceCloseEventMessage() : base()
        { }
        #endregion
    }
}
