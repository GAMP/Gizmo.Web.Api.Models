namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Set host id model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ApplicationLicenseSetHostIdModel : IWebApiModel
    {
        /// <summary>
        /// Host id.
        /// </summary>
        [MessagePack.Key(0)]
        public int? HostId { get; init; }
    }
}
