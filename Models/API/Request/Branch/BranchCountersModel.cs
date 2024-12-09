namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Branch counters model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class BranchCountersModel : IWebApiModel
    {
        /// <summary>
        /// Branch id.
        /// </summary>
        [MessagePack.Key(0)]
        public int BranchId { get; init; }

        /// <summary>
        /// Gets total endpoints.
        /// </summary>
        [MessagePack.Key(1)]
        public int Endpoints { get; init; }

        /// <summary>
        /// Gets total computers.
        /// </summary>
        [MessagePack.Key(2)]
        public int Computers { get; init; }

        /// <summary>
        /// Gets total controllers.
        /// </summary>
        [MessagePack.Key(3)]
        public int Controllers { get; init; }
    }
}
