﻿using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User group disallowed host group.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class UserGroupDisallowedHostGroup : UserGroupDisallowedHostGroupModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        [MessagePack.Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the user group.
        /// </summary>
        [DataMember]
        [MessagePack.Key(101)]
        public int UserGroupId { get; set; }

        #endregion
    }
}