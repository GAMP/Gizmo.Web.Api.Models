using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    [Serializable]
    [DataContract]
    public class RequiredUserInfo
    {
        #region PROPERTIES

        [DataMember]
        public bool FirstName { get; set; }

        [DataMember]
        public bool LastName { get; set; }

        [DataMember]
        public bool BirthDate { get; set; }

        [DataMember]
        public bool Address { get; set; }

        [DataMember]
        public bool City { get; set; }

        [DataMember]
        public bool PostCode { get; set; }

        [DataMember]
        public bool State { get; set; }

        [DataMember]
        public bool Country { get; set; }

        [DataMember]
        public bool Email { get; set; }

        [DataMember]
        public bool Phone { get; set; }

        [DataMember]
        public bool Mobile { get; set; }

        [DataMember]
        public bool Sex { get; set; }

        [DataMember]
        public bool Password { get; set; }

        [DataMember]
        public bool UserName { get; set; }

        [DataMember]
        public bool UserGroup { get; set; }

        #endregion
    }
}