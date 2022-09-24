using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application group.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationGroupModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the application group.
        /// </summary>
        [Required]
        [StringLength(45)]
        [MessagePack.Key(0)]
        public string Name { get; set; }

        #endregion
    }
}
