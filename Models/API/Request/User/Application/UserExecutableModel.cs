using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User executable model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserExecutableModel : IUserApplicationExecutableModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The Id of the application this executable belongs to.
        /// </summary>
        [Key(1)]
        public int ApplicationId { get; set; }

        /// <summary>
        /// The caption of the executable.
        /// </summary>
        [Key(2)]
        public string? Caption { get; set; }

        /// <summary>
        /// The description of the executable.
        /// </summary>
        [Key(3)]
        public string? Description { get; set; }

        /// <summary>
        /// The display order of the executable.
        /// </summary>
        [Key(4)]
        public int DisplayOrder { get; set; }

        #endregion
    }
}
