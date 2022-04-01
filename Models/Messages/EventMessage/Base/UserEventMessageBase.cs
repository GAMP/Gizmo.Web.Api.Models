﻿using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User event message base.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public abstract class UserEventMessageBase : EventMessage
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserEventMessageBase() : base()
        { } 
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets user id.
        /// </summary>
        [DataMember()]
        [Key(1)]
        public int UserId
        {
            get; set;
        } 

        #endregion
    }
}