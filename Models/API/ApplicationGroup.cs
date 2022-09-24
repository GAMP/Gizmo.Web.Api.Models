﻿using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application group.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationGroup : ApplicationGroupModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The GUID of the application group.
        /// </summary>
        [Key(101)]
        public Guid Guid { get; set; }

        #endregion
    }
}
