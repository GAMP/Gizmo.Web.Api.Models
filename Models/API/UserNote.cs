﻿using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User note.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class UserNote : UserNoteModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        [MessagePack.Key(100)]
        public int Id { get; set; }

        #endregion
    }
}
