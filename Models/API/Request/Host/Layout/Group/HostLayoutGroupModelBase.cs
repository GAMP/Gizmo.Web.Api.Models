using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Host.Layout.Group
{
    /// <summary>
    /// Host layout group.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class HostLayoutGroupModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the host group.
        /// </summary>
        [Required]
        [StringLength(45)]
        [MessagePack.Key(0)]
        public string Name { get; set; }

        /// <summary>
        /// The display order of the layout group.
        /// </summary>
        [MessagePack.Key(1)]
        public int DisplayOrder { get; set; }

        #endregion
    }
}