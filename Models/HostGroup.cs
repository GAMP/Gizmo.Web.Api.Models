using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host group.
    /// </summary>
    [Serializable]
    [DataContract]
    public class HostGroup : HostGroupModelBase, IEntityBase, IUrlQueryParameters
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