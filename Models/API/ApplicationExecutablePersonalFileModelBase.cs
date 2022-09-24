using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable personal file.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationExecutablePersonalFileModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the personal file associated with this application executable.
        /// </summary>
        [Required]
        [MessagePack.Key(0)]
        public int PersonalFileId { get; set; }

        /// <summary>
        /// The order in which the personal file is used.
        /// </summary>
        [MessagePack.Key(1)]
        public int UseOrder { get; set; }

        #endregion
    }
}