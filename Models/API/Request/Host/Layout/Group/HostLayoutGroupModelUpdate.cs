using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Host.Layout.Group
{
    /// <summary>
    /// Host layout group.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class HostLayoutGroupModelUpdate : HostLayoutGroupModelBase, IApiModelIdentifier, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(2)]
        public int Id { get; set; }

        #endregion
    }
}