using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// License reservation message.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public class LicenseReservationMessage : LicenseReservationMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public LicenseReservationMessage() : base()
        { } 
        #endregion
    }
}
