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
    public class ApplicationModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The title of the application.
        /// </summary>
        [Required]
        [DataMember]
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// The description of the application.
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// The version of the application.
        /// </summary>
        [DataMember]
        [StringLength(45)]
        public string Version { get; set; }

        /// <summary>
        /// The Id of the application category this application belongs to.
        /// </summary>
        [DataMember]
        public int ApplicationCategoryId { get; set; }

        /// <summary>
        /// Gets or Sets applications developer.
        /// </summary>
        [DataMember]
        public int? DeveloperId { get; set; }

        /// <summary>
        /// Gets or Sets applications publisher.
        /// </summary>
        [DataMember]
        public int? PublisherId { get; set; }

        /// <summary>
        /// Gets or sets applications age rating.
        /// </summary>
        [DataMember]
        public int AgeRating { get; set; }

        /// <summary>
        /// The release date of the application.
        /// </summary>
        [DataMember]
        public DateTime? ReleaseDate { get; set; }

        ///// <summary>
        ///// Gets or Sets application halt on error value.
        ///// </summary>
        //[DataMember]
        //TODO: A public AppOptionType Options { get; set; }

        /// <summary>
        /// Gets or sets default executable id.
        /// </summary>
        [DataMember]
        public int? DefaultExecutableId { get; set; }

        #endregion
    }
}