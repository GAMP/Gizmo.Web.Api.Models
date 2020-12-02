using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    [Serializable]
    [DataContract]
    public class TimeProductDisallowedHostGroupModelBase
    {
        #region PROPERTIES

        [DataMember]
        public int HostGroup { get; set; }

        [DataMember]
        public bool IsDisallowed { get; set; }

        #endregion
    }
}