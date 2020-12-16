using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Variable.
    /// </summary>
    [DataContract]
    [Serializable]
    public class VariableModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the variable.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// The value of the variable.
        /// </summary>
        [DataMember]
        public string Value { get; set; }

        [DataMember]
        public bool AvailableInServer { get; set; }

        [DataMember]
        public bool AvailableInClient { get; set; }

        [DataMember]
        public bool AvailableInManager { get; set; }

        #endregion
    }
}
