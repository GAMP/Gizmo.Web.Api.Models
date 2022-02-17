using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User enabled change event message.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public class UserEnabledChangedEventMessage : UserEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserEnabledChangedEventMessage() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets if user is disabled.
        /// </summary>
        [DataMember()]
        [Key(2)]
        public bool Disabled
        {
            get;
            init;
        }

        /// <summary>
        /// Gets enable date.
        /// </summary>
        [DataMember()]
        [Key(3)]
        public DateTime? EnableDate
        {
            get;
            init;
        }

        /// <summary>
        /// Gets disabled date.
        /// </summary>
        [DataMember()]
        [Key(4)]
        public DateTime? DisabledDate
        {
            get;
            init;
        }

        #endregion
    }
}
