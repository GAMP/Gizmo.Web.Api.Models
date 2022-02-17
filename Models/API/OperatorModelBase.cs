using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Operator.
    /// </summary>
    [DataContract]
    [Serializable]
    public class OperatorModelBase
    {
        #region PROPERTIES

        #region UsersOperator

        /// <summary>
        /// The username of the operator.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(30)]
        public string Username { get; set; }

        /// <summary>
        /// The email of the operator.
        /// </summary>
        [DataMember]
        [StringLength(254)]
        [EmailNullEmpty]
        public string Email { get; set; }

        #endregion

        #region User

        /// <summary>
        /// The first name of the operator.
        /// </summary>
        [DataMember]
        [StringLength(45)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the operator.
        /// </summary>
        [DataMember]
        [StringLength(45)]
        public string LastName { get; set; }

        /// <summary>
        /// The birth date of the operator.
        /// </summary>
        [DataMember]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The address of the operator.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        public string Address { get; set; }

        /// <summary>
        /// The city of the operator.
        /// </summary>
        [DataMember]
        [StringLength(45)]
        public string City { get; set; }

        /// <summary>
        /// The country of the operator.
        /// </summary>
        [DataMember]
        [StringLength(45)]
        public string Country { get; set; }

        /// <summary>
        /// The post code of the operator.
        /// </summary>
        [DataMember]
        [StringLength(20)]
        public string PostCode { get; set; }

        /// <summary>
        /// The phone number of the operator.
        /// </summary>
        [DataMember]
        [StringLength(20)]
        public string Phone { get; set; }

        /// <summary>
        /// The mobile phone number of the operator.
        /// </summary>
        [DataMember]
        [StringLength(20)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// The sex of the operator.
        /// </summary>
        [DataMember]
        [EnumValue]
        public Sex Sex { get; set; }

        /// <summary>
        /// Whether the operator is deleted.
        /// </summary>
        [DataMember]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Whether the operator is disabled.
        /// </summary>
        [DataMember]
        public bool IsDisabled { get; set; }

        /// <summary>
        /// The SmartCard UID of the operator.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        public string SmartCardUid { get; set; }

        /// <summary>
        /// The identification number of the operator.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        public string Identification { get; set; }

        #endregion

        #endregion
    }
}
