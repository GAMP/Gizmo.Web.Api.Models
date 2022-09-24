using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host layout.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class HostLayout : HostLayoutModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(6)]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the host layout group this host layout belongs to.
        /// </summary>
        [Key(7)]
        public int HostLayoutGroupId { get; set; }

        #endregion
    }
}