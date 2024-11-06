namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Companion connection info model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class CompanionConnectionInfoModel : HTTPConnectionInfoModel
    {
        /// <summary>
        /// Companion id.
        /// </summary>
        [MessagePack.Key(5)]
        public string? CompanionId
        {
            get; init;
        } = string.Empty;
    }
}
