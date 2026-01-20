namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Set user smart card UID model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class UserSetSmartCardUidModel : IWebApiModel
    {
        /// <summary>
        /// Smart card UID.
        /// </summary>
        /// <remarks>
        /// Setting to null or empty string will remove the smart card association.
        /// </remarks>
        [MessagePack.Key(0)]
        public string? SmartCardUid { get; set; } = null!;
    }
}
