﻿#nullable enable

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable personal file.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationExecutablePersonalFileModelUpdate : IApplicationExecutablePersonalFileModel
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the executable this personal file is associated with.
        /// </summary>
        [Key(0)]
        public int ApplicationExecutableId { get; set; }

        /// <summary>
        /// The Id of the personal file associated with this application executable.
        /// </summary>
        [Key(1)]
        public int PersonalFileId { get; set; }

        /// <summary>
        /// The order in which the personal file is used.
        /// </summary>
        [Key(2)]
        public int UseOrder { get; set; }

        #endregion
    }
}
