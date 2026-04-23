namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Instance license result.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class LicenseResultModel : IWebApiModel
    {
        /// <summary>
        /// Gets result.
        /// </summary>
        [MessagePack.Key(0)]
        public LicenseResult Result { get; init; }

        /// <summary>
        /// Gets license payload bytes.
        /// </summary>
        /// <remarks>
        /// Populated when <see cref="Result"/> is <see cref="LicenseResult.Available"/>; otherwise <c>null</c>.
        /// </remarks>
        [MessagePack.Key(1)]
        public byte[]? Payload { get; init; }

        /// <summary>
        /// Gets license signature bytes.
        /// </summary>
        /// <remarks>
        /// Populated when <see cref="Result"/> is <see cref="LicenseResult.Available"/>; otherwise <c>null</c>.
        /// </remarks>
        [MessagePack.Key(2)]
        public byte[]? Signature { get; init; }
    }
}
