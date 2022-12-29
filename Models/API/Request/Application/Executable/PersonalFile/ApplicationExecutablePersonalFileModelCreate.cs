﻿using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable personal file.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationExecutablePersonalFileModelCreate : IApplicationExecutablePersonalFileApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the personal file associated with this application executable.
        /// </summary>
        [Key(0)]
        public int PersonalFileId { get; set; }

        /// <summary>
        /// The order in which the personal file is used.
        /// </summary>
        [Key(1)]
        public int UseOrder { get; set; }

        #endregion
    }
}
