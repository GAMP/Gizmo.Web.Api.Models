using System;
using System.ComponentModel.DataAnnotations;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User personal information.
    /// </summary>
    [MessagePackObject]
    public sealed class UserPersonalInformationModel
    {
        #region PROPERTIES

        /// <summary>
        /// The first name of the user.
        /// </summary>
        [MessagePack.Key(0)]
        public string? FirstName { get; set; }

        /// <summary>
        /// The last name of the user.
        /// </summary>
        [MessagePack.Key(1)]
        public string? LastName { get; set; }

        /// <summary>
        /// The username of the user.
        /// </summary>
        [MessagePack.Key(2)]
        public string? Username { get; set; }

        /// <summary>
        /// The identification number of the user.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(3)]
        public string? Identification { get; set; }

        /// <summary>
        /// The sex of the user.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(4)]
        public Sex Sex { get; set; }

        /// <summary>
        /// The birth date of the user.
        /// </summary>
        [MessagePack.Key(5)]
        public DateTime? BirthDate { get; set; }

        #endregion
    }
}
