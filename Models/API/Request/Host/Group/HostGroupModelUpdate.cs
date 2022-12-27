using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Host.Group
{
    /// <summary>
    /// Host group.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class HostGroupModelUpdate : HostGroupModelBase, IApiModelIdentifier, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Required]
        [MessagePack.Key(5)]
        public int Id { get; set; }

        #endregion
    }
}