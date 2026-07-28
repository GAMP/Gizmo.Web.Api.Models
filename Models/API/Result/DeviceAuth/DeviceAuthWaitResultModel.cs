using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Device activation wait (long poll) result.
    /// </summary>
    [MessagePackObject]
    public sealed class DeviceAuthWaitResultModel : IWebApiModel
    {
        /// <summary>
        /// Session status. Pending means the poll timed out and the device should poll again.
        /// </summary>
        [Key(0)]
        public DeviceAuthSessionStatus Status { get; init; }

        /// <summary>
        /// Issued tokens, present only when status is approved. Delivered exactly once.
        /// </summary>
        [Key(1)]
        public AuthTokenResultModel? Token { get; init; }
    }
}
