﻿using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User picture changed event message.
    /// </summary>
    [MessagePackObject()]
    [HideMetadata()]
    public sealed class UserPictureChangedEventMessage : UserEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserPictureChangedEventMessage() : base()
        { } 
        #endregion
    }
}
