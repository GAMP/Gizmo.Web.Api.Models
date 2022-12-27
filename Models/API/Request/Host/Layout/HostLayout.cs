using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Host.Layout
{
    /// <summary>
    /// Host layout.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class HostLayout : HostLayoutModelBase, IApiModelIdentifier
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