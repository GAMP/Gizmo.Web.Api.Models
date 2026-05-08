namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Request model for starting the user duplicate-fix process.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class UserFixDuplicatesModel : IWebApiModel
    {
        /// <summary>
        /// Default country used when normalizing phone values that do not
        /// already contain a complete international calling code.
        /// </summary>
        [MessagePack.Key(0)]
        public required string DefaultCountryCode { get; init; }
    }
}
