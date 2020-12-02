using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    [Serializable]
    [DataContract]
    public class TimeProductDisallowedHostGroup : TimeProductDisallowedHostGroupModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        #endregion
    }
}