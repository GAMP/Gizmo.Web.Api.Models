using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User renamed event message.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public class UserRenamedEventMessage : UserEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserRenamedEventMessage() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets new user name.
        /// </summary>
        [DataMember()]
        [Key(2)]
        public string NewUserName
        {
            get;init;
        }

        /// <summary>
        /// Gets old user name.
        /// </summary>
        [DataMember()]
        [Key(3)]
        public string OldUserName
        {
            get;init;
        }

        #endregion
    }
}
