namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Security profile policy create model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class SecurityProfilePolicyModelCreate : IWebApiModel
    {
        /// <summary>
        /// Policy type.
        /// </summary>
        [MessagePack.Key(0)]
        public int Type { get; init; }
    }
}
