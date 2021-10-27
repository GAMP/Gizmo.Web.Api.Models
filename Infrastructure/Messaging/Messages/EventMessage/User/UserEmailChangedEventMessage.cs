using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User email changed event message.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public class UserEmailChangedEventMessage : UserEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserEmailChangedEventMessage() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets new email value.
        /// </summary>
        [DataMember()]
        [Key(2)]
        public string NewEmail
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets old email value.
        /// </summary>
        [DataMember()]
        [Key(3)]
        public string OldEmail
        {
            get;
            protected set;
        }

        #endregion
    }
}
