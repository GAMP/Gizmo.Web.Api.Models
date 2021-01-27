using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Gets
    /// </summary>
    [DataContract]
    [Serializable]
    public class ApplicationTaskScript
    {
        #region PROPERTIES

        ///// <summary>
        ///// Gets or sets script type.
        ///// </summary>
        //[DataMember()]
        //TODO: A public ScriptTypes ScriptType { get; set; }

        /// <summary>
        /// Gets or sets data.
        /// </summary>
        [DataMember()]
        [Required]
        [StringLength(65535)]
        public string Data { get; set; }

        ///// <summary>
        ///// Gets or sets process options.
        ///// </summary>
        //[DataMember]
        //TODO: A public TaskProcessOptionType ProcessOptions { get; set; }

        #endregion
    }
}