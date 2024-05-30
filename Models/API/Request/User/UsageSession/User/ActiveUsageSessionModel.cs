namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Active usage session model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ActiveUsageSessionModel
    {
        /// <summary>
        /// Usage session id.
        /// </summary>
        [MessagePack.Key(0)]
        public int? Id { get; set; }
    }
}
