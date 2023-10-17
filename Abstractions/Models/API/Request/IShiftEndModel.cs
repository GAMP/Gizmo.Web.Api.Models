using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Shift end model.
    /// </summary>
    public interface IShiftEndModel : IWebApiModel
    {
        /// <summary>
        /// Shift counts.
        /// </summary>
        IEnumerable<ShiftEndCountModel> Counts { get; }
    }
}
