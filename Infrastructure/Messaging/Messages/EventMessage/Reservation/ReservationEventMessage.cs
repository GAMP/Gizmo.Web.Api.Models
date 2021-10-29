using MessagePack;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Reservation event message.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public class ReservationEventMessage : ReservationEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ReservationEventMessage() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets reserved users.
        /// </summary>
        [DataMember()]
        [Key(2)]
        public HashSet<int> Users
        {
            get; set;
        }

        /// <summary>
        /// Gets reserved hosts.
        /// </summary>
        [DataMember()]
        [Key(3)]
        public HashSet<int> Hosts
        {
            get; set;
        }

        #endregion
    }
}
