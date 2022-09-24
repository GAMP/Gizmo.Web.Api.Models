using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application group application.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationGroupApplicationModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the application associated with this application group.
        /// </summary>
        [Required]
        [MessagePack.Key(0)]
        public int ApplicationId { get; set; }

        #endregion
    }
}
