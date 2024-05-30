namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Active usage rate model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UsageRateModel : UsageModel
    {
        /// <summary>
        /// Gets billing rate id.
        /// </summary>
        [MessagePack.Key(2)]
        public int BillRateId { get; init; }

        /// <summary>
        /// Gets billing profile id.
        /// </summary>
        [MessagePack.Key(3)]
        public int BillProfileId { get; init; }
    }
}
