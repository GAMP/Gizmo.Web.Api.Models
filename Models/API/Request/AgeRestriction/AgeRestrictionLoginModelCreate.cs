using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Age restriction login model create.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class AgeRestrictionLoginModelCreate : IWebApiModel
    {
        /// <summary>
        /// Age from.
        /// </summary>
        [MessagePack.Key(0)]
        [Required()]
        [Range(0, 100)]
        public int AgeFrom { get; init; }

        /// <summary>
        /// Age to.
        /// </summary>
        [MessagePack.Key(1)]
        [Required()]
        [Range(0, 100)]
        public int AgeTo { get; init; }

        /// <summary>
        /// The time from.
        /// </summary>
        [MessagePack.Key(2)]
        [Required()]
        [Range(0, 1440)]
        public int DayMinuteFrom { get; init; }

        /// <summary>
        /// The time to.
        /// </summary>
        [MessagePack.Key(3)]
        [Required()]
        [Range(0, 1440)]
        public int DayMinuteTo { get; init; }
    }
}
