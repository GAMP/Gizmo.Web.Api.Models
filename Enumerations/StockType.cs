using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Stock type.
    /// </summary>
    public enum StockType
    {
        /// <summary>
        /// Selling point.
        /// </summary>
        [Name("Selling Point", "STOCK_TYPE_SELLING_POINT")]
        SellingPoint = 0,

        /// <summary>
        /// Warehouse.
        /// </summary>
        [Name("Warehouse", "STOCK_TYPE_WAREHOUSE")]
        Warehouse = 1
    }
}
