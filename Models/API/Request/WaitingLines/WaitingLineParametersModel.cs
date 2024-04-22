namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Waiting line parameters model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class WaitingLineParametersModel : IWebApiModel
    {
        /// <summary>
        /// Enables or disables priorities.
        /// </summary>
        [MessagePack.Key(0)]
        public bool EnablePriorities
        {
            get; init;
        }

        /// <summary>
        /// Enables or disables next in line.
        /// </summary>
        [MessagePack.Key(1)]
        public bool EnableNextInLine
        {
            get; init;
        }

        /// <summary>
        /// Enables or disables remove on timeout.
        /// </summary>
        [MessagePack.Key(2)]
        public bool TimeoutRemove
        {
            get; init;
        }
    }
}
