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

        /// <summary>
        /// The caption of the link.
        /// </summary>
        [Key(1)]
        public string Caption { get; init; } = null!;

        /// <summary>
        /// The caption of the link.
        /// </summary>
        [Key(2)]
        public string Description { get; init; } = null!;

        /// <summary>
        /// The caption of the link.
        /// </summary>
        [Key(3)]
        public string Url { get; init; } = null!;

        /// <summary>
        /// The caption of the link.
        /// </summary>
        [Key(4)]
        public int DisplayOrder { get; init; }

        #endregion
    }
}
