namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Branch reference update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class BranchReferenceModelUpdate : IWebApiModel
    {
        /// <summary>
        /// Branch id.
        /// </summary>
        [MessagePack.Key(0)]
        public int BranchId { get; init; }

        /// <summary>
        /// Reference state.
        /// </summary>
        [MessagePack.Key(1)]
        public bool IsEnabled { get; init; }
    }
}
