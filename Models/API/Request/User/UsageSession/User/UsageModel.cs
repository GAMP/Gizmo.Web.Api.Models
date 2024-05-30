namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Usage model.
    /// </summary>
    [MessagePack.Union(0, typeof(UsageRateModel))]
    [MessagePack.Union(1, typeof(UsageProductTimeModel))]
    [MessagePack.Union(2, typeof(UsageProductTimeFixedModel))]
    [MessagePack.MessagePackObject()]
    public abstract class UsageModel : IWebApiModel
    {
        /// <summary>
        /// Usage session id.
        /// </summary>
        [MessagePack.Key(0)]
        public int UsageSessionId { get; init; }

        /// <summary>
        /// Usage id.
        /// </summary>
        [MessagePack.Key(1)]
        public int Id { get; set; }
    }
}
