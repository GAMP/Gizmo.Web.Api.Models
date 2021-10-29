﻿using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Reservation event message base.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public abstract class ReservationEventMessageBase : EventMessage
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ReservationEventMessageBase() : base(EventMessageTypeCache.IReservationEventMessage)
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets reservation id.
        /// </summary>
        [DataMember()]
        [Key(1)]
        public int ReservationId
        {
            get; protected set;
        }

        #endregion
    }
}