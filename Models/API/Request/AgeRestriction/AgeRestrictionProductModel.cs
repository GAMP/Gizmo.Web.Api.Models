using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Age restriction product model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class AgeRestrictionProductModel : AgeRestrictionModel , IModelIntIdentifier
    {
        ///<inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Age from.
        /// </summary>
        [MessagePack.Key(1)]
        public int AgeFrom { get; init; }

        /// <summary>
        /// Age to.
        /// </summary>
        [MessagePack.Key(2)]
        public int AgeTo { get; init; }

        /// <summary>
        /// The time from.
        /// </summary>
        [MessagePack.Key(3)]
        public int? DayMinuteFrom { get; init; }

        /// <summary>
        /// The time to.
        /// </summary>
        [MessagePack.Key(4)]
        public int? DayMinuteTo { get; init; }

        /// <summary>
        /// Gets product id.
        /// </summary>
        [MessagePack.Key(5)]
        public int ProductId { get; init; }
    }
}
