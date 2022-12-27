using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Host.Model
{
    /// <summary>
    /// Host.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class HostModelCreate : HostModelBase, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The type of the host.
        /// </summary>
        [Required]
        [EnumValueValidation]
        [MessagePack.Key(100)]
        public HostType HostType { get; set; }

        #endregion
    }
}