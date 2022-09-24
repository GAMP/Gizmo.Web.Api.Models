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
    public class ApplicationExecutablePersonalFileModelUpdate : ApplicationExecutablePersonalFileModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the executable this personal file is associated with.
        /// </summary>
        [Required]
        [MessagePack.Key(100)]
        public int ApplicationExecutableId { get; set; }

        #endregion
    }
}
