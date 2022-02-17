using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User session changed event message.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public class UserSessionChangedEventMessage : UserEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserSessionChangedEventMessage() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets new state.
        /// </summary>
        [DataMember()]
        [Key(2)]
        public UserSessionState State
        {
            get; init;
        }

        /// <summary>
        /// Gets span.
        /// </summary>
        [DataMember()]
        [Key(3)]
        public double Span
        {
            get; init;
        }

        /// <summary>
        /// Gets slot.
        /// </summary>
        [DataMember()]
        [Key(4)]
        public int Slot
        {
            get; init;
        }

        /// <summary>
        /// Gets user session host id.
        /// </summary>
        [DataMember()]
        [Key(5)]
        public int HostId
        {
            get; init;
        }

        #endregion
    }
}
