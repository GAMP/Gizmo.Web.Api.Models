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
        /// Gets or sets username.
        /// </summary>
        [DataMember]
        [Required()]
        [StringLength(30)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets email.
        /// </summary>
        [DataMember]
        [StringLength(254)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets users group id.
        /// </summary>
        [DataMember]
        public int UserGroupId { get; set; }

        /// <summary>
        /// Gets or sets if user allowed to have negative balance.
        /// </summary>
        [DataMember]
        public bool? IsNegativeBalanceAllowed { get; set; }

        /// <summary>
        /// Gets or sets if personal info is requested.
        /// </summary>
        [DataMember]
        public bool IsPersonalInfoRequested { get; set; }

        ///// <summary>
        ///// Gets or sets billing options.
        ///// </summary>
        //[DataMember]
        //public BillingOption? BillingOptions { get; set; }

        /// <summary>
        /// Gets or sets user re-enable date-time.
        /// </summary>
        [DataMember]
        public DateTime? EnableDate { get; set; }

        /// <summary>
        /// Gets or sets disabled date-time.
        /// </summary>
        [DataMember]
        public DateTime? DisabledDate { get; set; }

        #endregion

        #region User

        /// <summary>
        /// Gets or sets first name.
        /// </summary>
        [DataMember]
        [StringLength(45)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets last name.
        /// </summary>
        [DataMember]
        [StringLength(45)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets birth date.
        /// </summary>
        [DataMember]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Gets or sets address.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets city.
        /// </summary>
        [DataMember]
        [StringLength(45)]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets country.
        /// </summary>
        [DataMember]
        [StringLength(45)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets post code.
        /// </summary>
        [DataMember]
        [StringLength(20)]
        public string PostCode { get; set; }

        /// <summary>
        /// Gets or sets phone number.
        /// </summary>
        [DataMember]
        [StringLength(20)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets mobile phone number.
        /// </summary>
        [DataMember]
        [StringLength(20)]
        public string MobilePhone { get; set; }

        ///// <summary>
        ///// Gets or sets sex.
        ///// </summary>
        //[DataMember]
        //public Sex Sex { get; set; }

        /// <summary>
        /// Gets or sets if user is deleted.
        /// </summary>
        [DataMember]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets if user is enabled.
        /// </summary>
        [DataMember]
        public bool IsDisabled { get; set; }

        /// <summary>
        /// Gets or sets item guid.
        /// </summary>
        [Required()]
        [DataMember]
        public Guid Guid { get; set; }

        /// <summary>
        /// Gets or sets SmartCard UID.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        public string SmartCardUID { get; set; }

        /// <summary>
        /// Gets or sets identification number.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        public string Identification { get; set; }

        #endregion

        #endregion
    }
}