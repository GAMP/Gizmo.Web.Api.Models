using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Period day time.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PeriodDayTimeModel : IWebApiModel
    {
        /// <summary>
        /// Period day start time second.
        /// </summary>
        [MessagePack.Key(0)]
        [Range(0, 86400)]
        public int StartSecond { get; set; }

        /// <summary>
        /// Period day end time second.
        /// </summary>
        [MessagePack.Key(1)]
        [Range(0, 86400)]
        public int EndSecond { get; set; }
    }
}
