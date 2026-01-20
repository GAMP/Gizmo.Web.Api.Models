using System;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application license.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationLicenseModel : IApplicationLicenseModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public required int Id { get; init; }

        /// <summary>
        /// The GUID of the application license.
        /// </summary>
        [MessagePack.Key(1)]
        public required Guid Guid { get; init; }

        /// <summary>
        /// The name of the license.
        /// </summary>
        [MessagePack.Key(2)]
        public required string Name { get; set; }

        /// <summary>
        /// Plugin identifier.
        /// </summary>
        [MessagePack.Key(3)]
        public required Guid Plugin { get; init; }

        #endregion
    }
}
