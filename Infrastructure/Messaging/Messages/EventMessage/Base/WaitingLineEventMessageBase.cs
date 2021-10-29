﻿using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Waiting line event message base.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public abstract class WaitingLineEventMessageBase : EventMessage , IWaitingLineEventMessage
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public WaitingLineEventMessageBase() : base(EventMessageTypeCache.IHostEventMessage)
        {
        }
        #endregion
    }
}
