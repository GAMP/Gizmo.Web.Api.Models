namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Branch reference model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class BranchReferenceModel : IWebApiModel
    {
        /// <summary>
        /// Reference state.
        /// </summary>
        /// <remarks>
        /// Null value will indicate that there is no reference present for the branch.
        /// </remarks>
        [MessagePack.Key(0)]
        public bool? IsEnabled { get; init; }

        /// <summary>
        /// Branch id.
        /// </summary>
        [MessagePack.Key(1)]
        public int BranchId { get; init; }
    }
}
