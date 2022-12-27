using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Application.Enterprise
{
    /// <summary>
    /// Application enterprise.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationEnterprise : IApplicationEnterpriseApiModel, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The GUID of the application enterprise.
        /// </summary>
        [MessagePack.Key(1)]
        public Guid Guid { get; set; }

        /// <summary>
        /// The name of the enterprise.
        /// </summary>
        [MessagePack.Key(2)]
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        #endregion
    }
}
