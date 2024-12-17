namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Instance authorization result.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class AuthorizationResultModel : IWebApiModel
    {
        /// <summary>
        /// Gets result.
        /// </summary>
        [MessagePack.Key(0)]
        public AuthorizationResultCodes Result {  get; init; }

        /// <summary>
        /// Gets license state.
        /// </summary>
        [MessagePack.Key(1)]
        public LicenseState? LicenseState { get; init; }
    }
}
