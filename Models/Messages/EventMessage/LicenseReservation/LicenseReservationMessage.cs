﻿using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// License reservation message.
    /// </summary>
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
