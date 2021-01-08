using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User.
    /// </summary>
    [DataContract]
    [Serializable]
    public class UserModelBase
    {
        #region PROPERTIES

        #region UserMember

        /// <summary>
        /// The username of the user.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(30)]
        public string Username { get; set; }

        /// <summary>
        /// The email of the user.
        /// </summary>
        [DataMember]
        [StringLength(254)]
        public string Email { get; set; }

        /// <summary>
        /// The Id of the users group id this user belongs to.
        /// </summary>
        [DataMember]
        [Required]
        public int UserGroupId { get; set; }

        /// <summary>
        /// Whether the user is allowed to have negative balance.
        /// </summary>
        [DataMember]
        public bool? IsNegativeBalanceAllowed { get; set; }

        /// <summary>
        /// Whether the personal info has been requested from the user.
        /// </summary>
        [DataMember]
        public bool IsPersonalInfoRequested { get; set; }

        /// <summary>
        /// The date the user will be enabled again.
        /// </summary>
        [DataMember]
        public DateTime? EnableDate { get; set; }

        /// <summary>
        /// The date the user has been disabled.
        /// </summary>
        [DataMember]
        public DateTime? DisabledDate { get; set; }

        #endregion

        #region User

        /// <summary>
        /// The first name of the user.
        /// </summary>
        [DataMember]
        [StringLength(45)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the user.
        /// </summary>
        [DataMember]
        [StringLength(45)]
        public string LastName { get; set; }

        /// <summary>
        /// The birth date of the user.
        /// </summary>
        [DataMember]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The address of the user.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        public string Address { get; set; }

        /// <summary>
        /// The city of the user.
        /// </summary>
        [DataMember]
        [StringLength(45)]
        public string City { get; set; }

        /// <summary>
        /// The country of the user.
        /// </summary>
        [DataMember]
        [StringLength(45)]
        public string Country { get; set; }

        /// <summary>
        /// The post code of the user.
        /// </summary>
        [DataMember]
        [StringLength(20)]
        public string PostCode { get; set; }

        /// <summary>
        /// The phone number of the user.
        /// </summary>
        [DataMember]
        [StringLength(20)]
        public string Phone { get; set; }

        /// <summary>
        /// The mobile phone number of the user.
        /// </summary>
        [DataMember]
        [StringLength(20)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// The sex of the user.
        /// </summary>
        [DataMember]
        public Sex Sex { get; set; }

        /// <summary>
        /// Whether the user is deleted.
        /// </summary>
        [DataMember]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Whether the user is disabled.
        /// </summary>
        [DataMember]
        public bool IsDisabled { get; set; }

        /// <summary>
        /// The SmartCard UID of the user.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        public string SmartCardUid { get; set; }

        /// <summary>
        /// The identification number of the user.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        public string Identification { get; set; }

        #endregion

        #endregion
    }
}