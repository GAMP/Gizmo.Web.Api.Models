namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Waiting line user group priority model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class WaitingLinePriorityModel : IWebApiModel
    {
        /// <summary>
        /// User group id.
        /// </summary>
        [MessagePack.Key(0)]
        public int UserGroupId
        {
            get; init;
        }

        /// <summary>
        /// Priority.
        /// </summary>
        [MessagePack.Key(1)]
        public int Priority
        {
            get; init;
        }
    }
}
