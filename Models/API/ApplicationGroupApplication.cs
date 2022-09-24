using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application group application.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationGroupApplication : ApplicationGroupApplicationModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the application group.
        /// </summary>
        [Key(100)]
        public int ApplicationGroupId { get; set; }

        #endregion
    }
}
