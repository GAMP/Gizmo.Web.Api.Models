namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User search result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserSearchResultModel : IWebApiModel
    {
        /// <summary>
        /// User id.
        /// </summary>
        [MessagePack.Key(0)]
        public int UserId { get; set; }

        /// <summary>
        /// Match rank, lower value indicates a better match.
        /// </summary>
        /// <remarks>
        /// Not serialized, exists so the rank can be used as sortable property name.
        /// </remarks>
        [MessagePack.IgnoreMember()]
        [System.Text.Json.Serialization.JsonIgnore()]
        [Sortable()]
        public int Rank { get; set; }
    }
}
