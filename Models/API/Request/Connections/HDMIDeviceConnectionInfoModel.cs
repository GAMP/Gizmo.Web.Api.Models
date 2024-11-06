namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Device connection info model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class HDMIDeviceConnectionInfoModel : HTTPConnectionInfoModel
    {
        /// <summary>
        /// Device id.
        /// </summary>
        [MessagePack.Key(5)]
        public string? DeviceId
        {
            get; init;
        } = string.Empty;
    }
}
