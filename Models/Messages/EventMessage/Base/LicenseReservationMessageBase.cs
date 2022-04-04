using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// License reservation message base.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public abstract class LicenseReservationMessageBase : APIEventMessage
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public LicenseReservationMessageBase() : base()
        {
        } 
        #endregion
    }
}
