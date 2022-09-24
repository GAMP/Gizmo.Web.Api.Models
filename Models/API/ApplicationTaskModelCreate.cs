using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application task.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationTaskModelCreate : ApplicationTaskModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The type of the application task.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(100)]
        public TaskType TaskType { get; set; }

        #endregion
    }
}
