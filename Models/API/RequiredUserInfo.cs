using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Required user info.
    /// </summary>
    [Serializable]
    [DataContract]
    public class RequiredUserInfo
    {
        #region PROPERTIES

        /// <summary>
        /// Whether the first name of the user is required.
        /// </summary>
        [DataMember]
        public bool FirstName { get; set; }

        /// <summary>
        /// Whether the last name of the user is required.
        /// </summary>
        [DataMember]
        public bool LastName { get; set; }

        /// <summary>
        /// Whether the birth date of the user is required.
        /// </summary>
        [DataMember]
        public bool BirthDate { get; set; }

        /// <summary>
        /// Whether the address of the user is required.
        /// </summary>
        [DataMember]
        public bool Address { get; set; }

        /// <summary>
        /// Whether the city of the user is required.
        /// </summary>
        [DataMember]
        public bool City { get; set; }

        /// <summary>
        /// Whether the post code of the user is required.
        /// </summary>
        [DataMember]
        public bool PostCode { get; set; }

        /// <summary>
        /// Whether the state of the user is required.
        /// </summary>
        [DataMember]
        public bool State { get; set; }

        /// <summary>
        /// Whether the country of the user is required.
        /// </summary>
        [DataMember]
        public bool Country { get; set; }

        /// <summary>
        /// Whether the e-mail of the user is required.
        /// </summary>
        [DataMember]
        public bool Email { get; set; }

        /// <summary>
        /// Whether the phone of the user is required.
        /// </summary>
        [DataMember]
        public bool Phone { get; set; }

        /// <summary>
        /// Whether the mobile phone of the user is required.
        /// </summary>
        [DataMember]
        public bool Mobile { get; set; }

        /// <summary>
        /// Whether the sex of the user is required.
        /// </summary>
        [DataMember]
        public bool Sex { get; set; }

        /// <summary>
        /// Whether a password for the user is required.
        /// </summary>
        [DataMember]
        public bool Password { get; set; }

        #endregion
    }
}