using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User executable deployment profile model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserExecutableDeploymentProfileModel : IUserExecutableDeploymentProfileModel
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets deployment profile id.
        /// </summary>
        [Key(0)]
        public int DeploymentProfileId { get; init; }

        #endregion
    }
}
