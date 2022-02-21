using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application group application.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ApplicationGroupApplicationModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the application associated with this application group.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(0)]
        public int ApplicationId { get; set; }

        #endregion
    }
}
