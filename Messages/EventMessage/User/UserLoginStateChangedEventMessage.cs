using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User login state event message.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public class UserLoginStateChangedEventMessage : UserEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserLoginStateChangedEventMessage() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets new user login state.
        /// </summary>
        [DataMember()]
        [Key(2)]
        public UserLoginState NewState
        {
            get;
            init;
        }

        /// <summary>
        /// Gets old user login state.
        /// </summary>
        [DataMember()]
        [Key(3)]
        public UserLoginState OldState
        {
            get;
            init;
        }

        /// <summary>
        /// Gets host id.
        /// </summary>
        [DataMember()]
        [Key(4)]
        public int HostId
        {
            get;
            init;
        }

        #endregion
    }
}
