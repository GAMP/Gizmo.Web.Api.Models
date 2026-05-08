namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Supported phone country entry for user maintenance flows.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class UserPhoneCountryCodeModel : IWebApiModel
    {
        /// <summary>
        /// ISO 3166-1 alpha-2 country code.
        /// </summary>
        [MessagePack.Key(0)]
        public required string CountryCode { get; init; }

        /// <summary>
        /// International calling code including the leading plus sign.
        /// </summary>
        [MessagePack.Key(1)]
        public required string CallingCode { get; init; }

        /// <summary>
        /// Expected local-number length after the calling code is removed.
        /// </summary>
        [MessagePack.Key(2)]
        public required int LocalNumberLength { get; init; }
    }
}
