using MessagePack;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Variable.
    /// </summary>
    [DataContract]
    [MessagePackObject]
    public class VariableModelUpdate : VariableModelBase, IEntityBase, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        [Required]
        [MessagePack.Key(5)]
        public int Id { get; set; }

        #endregion
    }
}
