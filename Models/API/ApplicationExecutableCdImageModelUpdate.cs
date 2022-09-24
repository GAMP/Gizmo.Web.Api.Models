using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable cd image.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationExecutableCdImageModelUpdate : ApplicationExecutableCdImageModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Required]
        [MessagePack.Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the executable this cd image belongs to.
        /// </summary>
        [Required]
        [MessagePack.Key(101)]
        public int ApplicationExecutableId { get; set; }

        #endregion
    }
}
