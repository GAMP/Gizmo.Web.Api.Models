using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User application link model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserApplicationLinkModel : IUserApplicationLinkModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        #endregion
    }
}
