namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Access token request model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class AccessTokenRequestModel
    {
        /// <summary>
        /// Username.
        /// </summary>
        [MessagePack.Key(0)]
        public string Username
        {
            get; init;
        } =string.Empty;

        /// <summary>
        /// Password.
        /// </summary>
        [MessagePack.Key(1)]
        public string Password
        {
            get; init;
        } = string.Empty;

        /// <summary>
        /// Branch id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? BranchId
        {
            get; init;
        }
    }
}
