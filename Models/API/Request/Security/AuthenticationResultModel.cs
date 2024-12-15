namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Authentication result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class AuthenticationResultModel : IWebApiModel
    {
        /// <summary>
        /// Result code.
        /// </summary>
        [MessagePack.Key(0)]
        public AuthenticationResultCodes Result {  get; init; }
    }
}
