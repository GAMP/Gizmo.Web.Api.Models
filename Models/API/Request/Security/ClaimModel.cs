namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Claim model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class ClaimModel : IWebApiModel
    {
        /// <summary>
        /// Gets or sets the claim type.
        /// </summary>
        [MessagePack.Key(0)]
        public string Type { get; init; } = string.Empty;

        /// <summary>
        /// Gets or sets the claim value.
        /// </summary>
        [MessagePack.Key(1)]
        public string Value { get; init; } = string.Empty;
    }
}
