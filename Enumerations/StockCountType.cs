using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Stock count type.
    /// </summary>
    public enum StockCountType
    {
        [Name("Default", "SHIFT_COUNT_TYPE_DEFAULT")]
        Default = 0,

        [Name("Shift Open", "SHIFT_COUNT_TYPE_SHIFT_OPEN")]
        ShiftOpen = 1,

        [Name("Shift Close", "SHIFT_COUNT_TYPE_SHIFT_CLOSE")]
        ShiftClose = 2,
    }
}
