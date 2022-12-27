using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Host.Model
{
    /// <summary>
    /// Host.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class HostModelUpdate : HostModelBase, IApiModelIdentifier, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(100)]
        public int Id { get; set; }

        #endregion
    }
}