using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Device activation session creation model.
    /// </summary>
    /// <remarks>
    /// Sent anonymously by a device app to start a phone-approved activation.
    /// The context reference is resolved and validated server side by the
    /// flow handler registered for the app kind; it is never treated as a credential.
    /// </remarks>
    [MessagePackObject]
    public sealed class DeviceAuthSessionCreateModel : IWebApiModel
    {
        /// <summary>
        /// Application kind requesting activation, e.g. "kitchen".
        /// </summary>
        [Key(0)]
        public string AppKind { get; set; } = null!;

        /// <summary>
        /// Optional app specific context reference, e.g. a kitchen binding uid.
        /// </summary>
        [Key(1)]
        public string? ContextUid { get; set; }
    }
}
