using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User executable personal file model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserExecutablePersonalFileModel : IUserExecutablePersonalFileModel, IModelIntIdentifier
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
