namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Device host relation model.
    /// </summary>
    public interface IDeviceHostApiModel : IWebApiClientModel
    {
        /// <summary>
        /// Gets device id.
        /// </summary>
        int DeviceId { get; set; }
    }
}