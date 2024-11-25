using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User permission set update model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class UserPermissionSetModelUpdate : IWebApiModel, IModelIntIdentifier
    {
        ///<inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets the permissions.
        /// </summary>
        [MessagePack.Key(2)]
        public IEnumerable<UserPermissionModel> Permissions { get; set; } = Enumerable.Empty<UserPermissionModel>();
    }
}
