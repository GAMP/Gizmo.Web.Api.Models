using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    [Serializable]
    [DataContract]
    public class ProductDisallowedUserGroupModelBase
    {
        #region PROPERTIES

        [DataMember]
        public int UserGroup { get; set; }

        #endregion
    }
}