using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host layout group.
    /// </summary>
    [Serializable]
    [DataContract]
    public class HostLayoutGroup : HostLayoutGroupModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// The host layouts of the host layout group.
        /// </summary>
        [DataMember]
        public IEnumerable<HostLayout> HostLayouts { get; set; }

        #endregion
    }
}