using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User enable negative balance changed event message.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public class UserEnableNegativeBalanceEventMessage : UserEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserEnableNegativeBalanceEventMessage() : base()
        { }
        #endregion

        #region PROPERTIES
        /// <summary>
        /// Gets if negative balance allowed for user.
        /// </summary>
        [DataMember()]
        [Key(2)]
        public bool? Enabled
        {
            get; protected set;
        }
        #endregion
    }
}
