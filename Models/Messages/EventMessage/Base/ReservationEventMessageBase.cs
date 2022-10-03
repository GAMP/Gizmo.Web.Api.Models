using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Reservation event message base.
    /// </summary>
    public abstract class ReservationEventMessageBase : APIEventMessage
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ReservationEventMessageBase() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets reservation id.
        /// </summary>
        [Key(1)]
        public int ReservationId
        {
            get; protected set;
        }

        #endregion
    }
}
