using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ApplicationModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The title of the application.
        /// </summary>
        [Required]
        [DataMember]
        [StringLength(255)]
        [MessagePack.Key(0)]
        public string Title { get; set; }

        /// <summary>
        /// The description of the application.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public string Description { get; set; }

        /// <summary>
        /// The version of the application.
        /// </summary>
        [DataMember]
        [StringLength(45)]
        [MessagePack.Key(2)]
        public string Version { get; set; }

        /// <summary>
        /// The Id of the application category this application belongs to.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(3)]
        public int ApplicationCategoryId { get; set; }

        /// <summary>
        /// The Id of the application enterprise that is the developer of the application.
        /// </summary>
        [DataMember]
        [MessagePack.Key(4)]
        public int? DeveloperId { get; set; }

        /// <summary>
        /// The Id of the application enterprise that is the publisher of the application.
        /// </summary>
        [DataMember]
        [MessagePack.Key(5)]
        public int? PublisherId { get; set; }

        /// <summary>
        /// The age rating of the application.
        /// </summary>
        [DataMember]
        [MessagePack.Key(6)]
        public int AgeRating { get; set; }

        /// <summary>
        /// The release date of the application.
        /// </summary>
        [DataMember]
        [MessagePack.Key(7)]
        public DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// The Id of the executable this application uses by default.
        /// </summary>
        [DataMember]
        [MessagePack.Key(8)]
        public int? DefaultExecutableId { get; set; }

        #endregion
    }
}