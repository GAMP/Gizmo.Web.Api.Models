namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User search result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserSearchResult : IWebApiModel
    {
        /// <summary>
        /// User id.
        /// </summary>
        [MessagePack.Key(0)]
        public int UserId { get; set; }
    }
}
