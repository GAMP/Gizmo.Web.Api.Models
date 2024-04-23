namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Waiting line parameters model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class WaitingLineModel : IWebApiModel
    {
        /// <summary>
        /// Host group id.
        /// </summary>
        [MessagePack.Key(0)]
        public int HostGroupId
        {
            get; init;
        }

        /// <summary>
        /// Indicates if timeout removal is enabled.
        /// </summary>
        [MessagePack.Key(1)]
        public bool TimeoutRemoveEnabled
        {
            get; init;
        }

        /// <summary>
        /// Indicates if priorities are enabled.
        /// </summary>
        [MessagePack.Key(2)]
        public bool PrioritiesEnabled
        {
            get; init;
        }

        /// <summary>
        /// Indicates if next in line is enabled.
        /// </summary>
        [MessagePack.Key(3)]
        public bool NextInLineEnabled
        {
            get; init;
        }
    }
}
