using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class Host : HostModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The type of the host.
        /// </summary>
        [Required]
        [EnumValueValidation]
        [MessagePack.Key(101)]
        public HostType HostType { get; set; }

        #endregion
    }
}