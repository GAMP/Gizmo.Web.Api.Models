using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Predefined document types for the system.
    /// </summary>
    public enum DocumentTypes
    {
        /// <summary>
        /// Delivery note.
        /// </summary>
        [Name("Delivery note")]
        DeliveryNote = -1,
        /// <summary>
        /// Dispatch note.
        /// </summary>
        [Name("Dispatch note")]
        DispatchNote = -2,
        /// <summary>
        /// Stock take report.
        /// </summary>
        [Name("Stock take report")]
        StockTakeReport = -3,
        /// <summary>
        /// Write-off report.
        /// </summary>
        [Name("Write-off report")]
        WriteOffReport = -4,
        /// <summary>
        /// Consignment note.
        /// </summary>
        [Name("Consignment note")]
        ConsignmentNote = -5,
        /// <summary>
        /// Invoice.
        /// </summary>
        [Name("Invoice")]
        Invoice = -6,
        /// <summary>
        /// Work order.
        /// </summary>
        [Name("Work order")]
        WorkOrder = -7,
    }
}
