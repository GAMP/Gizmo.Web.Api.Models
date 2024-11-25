using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User permission set create model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserPermissionSetModelCreate : IWebApiModel
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [MessagePack.Key(0)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets the permissions.
        /// </summary>
        [MessagePack.Key(1)]
        public IEnumerable<UserPermissionModel> Permissions { get; set; } = Enumerable.Empty<UserPermissionModel>();
    }
}
