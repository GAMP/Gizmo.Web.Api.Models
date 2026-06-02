namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User logout model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserLogoutModel : IWebApiModel
    {
        /// <summary>
        /// Logout flags.
        /// </summary>
        [MessagePack.Key(0)]
        public UserLogoutFlags Flags { get; set; }

        /// <summary>
        /// Whether to wait for the client to acknowledge the logout action.
        /// </summary>
        [MessagePack.Key(1)]
        public bool? WaitForClient { get; set; }
    }
}
