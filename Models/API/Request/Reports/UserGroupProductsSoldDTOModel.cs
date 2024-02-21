namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product sales for a user group.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class UserGroupProductsSoldDTOModel
    {
        /// <summary>
        /// User group name.
        /// </summary>
        [MessagePack.Key(0)]
        public string? UserGroupName { get; set; }

        /// <summary>
        /// Product information.
        /// </summary>
        [MessagePack.Key(1)]
        public GroupProductSoldDTOModel Product { get; set; }
    }
}
