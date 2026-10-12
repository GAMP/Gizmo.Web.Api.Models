using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Current user profile partial update model.
    /// </summary>
    /// <remarks>
    /// A null property is not changed.
    /// </remarks>
    [Serializable, MessagePackObject]
    public sealed class UserProfileModelUserUpdate
    {
        /// <summary>
        /// The first name of the user; null leaves the value unchanged.
        /// </summary>
        [StringLength(45)]
        [MessagePack.Key(0)]
        public string? FirstName { get; set; }

        /// <summary>
        /// The last name of the user; null leaves the value unchanged.
        /// </summary>
        [StringLength(45)]
        [MessagePack.Key(1)]
        public string? LastName { get; set; }

        /// <summary>
        /// The birth date of the user; null leaves the value unchanged.
        /// </summary>
        [MessagePack.Key(2)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The sex of the user; null leaves the value unchanged.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(3)]
        public Sex? Sex { get; set; }

        /// <summary>
        /// The email of the user; null leaves the value unchanged.
        /// </summary>
        [StringLength(254)]
        [EmailNullEmptyValidation]
        [MessagePack.Key(4)]
        public string? Email { get; set; }

        /// <summary>
        /// The mobile phone number of the user; null leaves the value unchanged.
        /// </summary>
        [StringLength(20)]
        [MessagePack.Key(5)]
        public string? MobilePhone { get; set; }

        /// <summary>
        /// The phone number of the user; null leaves the value unchanged.
        /// </summary>
        [StringLength(20)]
        [MessagePack.Key(6)]
        public string? Phone { get; set; }

        /// <summary>
        /// The address of the user; null leaves the value unchanged.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(7)]
        public string? Address { get; set; }

        /// <summary>
        /// The city of the user; null leaves the value unchanged.
        /// </summary>
        [StringLength(45)]
        [MessagePack.Key(8)]
        public string? City { get; set; }

        /// <summary>
        /// The post code of the user; null leaves the value unchanged.
        /// </summary>
        [StringLength(20)]
        [MessagePack.Key(9)]
        public string? PostCode { get; set; }

        /// <summary>
        /// The country of the user; null leaves the value unchanged.
        /// </summary>
        [StringLength(45)]
        [MessagePack.Key(10)]
        public string? Country { get; set; }
    }
}
