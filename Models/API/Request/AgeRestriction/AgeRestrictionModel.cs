using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Age restriction model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    [MessagePack.Union((int)AgeRestrictionType.Login, typeof(AgeRestrictionLoginModel))]
    public abstract class AgeRestrictionModel : IWebApiModel , IModelIntIdentifier
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
    }
}
