using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Host.Icon
{
    /// <summary>
    /// Host icon.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class HostIcon : HostIconModelBase, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(1)]
        public int Id { get; set; }

        #endregion
    }
}
