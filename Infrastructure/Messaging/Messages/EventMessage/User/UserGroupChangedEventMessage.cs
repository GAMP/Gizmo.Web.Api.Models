using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User group changed event message.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public class UserGroupChangedEventMessage : UserEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserGroupChangedEventMessage() : base()
        { }
        #endregion

        #region PROPERTIES
        
        /// <summary>
        /// Gets new user group id.
        /// </summary>
        [DataMember()]
        [Key(2)]
        public int NewUserGroupId
        {
            get; init;
        }

        /// <summary>
        /// Gets old user group id.
        /// </summary>
        [DataMember()]
        [Key(3)]
        public int OldUserGroupId
        {
            get; init;
        } 

        #endregion
    }
}
