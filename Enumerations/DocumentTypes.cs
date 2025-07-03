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
        [Name("Delivery note", "DOCUMENT_TYPES_DELIVERY_NOTE")]
        DeliveryNote = -1,
        /// <summary>
        /// Dispatch note.
        /// </summary>
        [Name("Dispatch note", "DOCUMENT_TYPES_DISPATCH_NOTE")]
        DispatchNote = -2,
        /// <summary>
        /// Stock take report.
        /// </summary>
        [Name("Stock take report", "DOCUMENT_TYPES_STOCK_TAKE_REPORT")]
        StockTakeReport = -3,
        /// <summary>
        /// Write-off report.
        /// </summary>
        [Name("Write-off report", "DOCUMENT_TYPES_WRITE_OFF_REPORT")]
        WriteOffReport = -4,
        /// <summary>
        /// Consignment note.
        /// </summary>
        [Name("Consignment note", "DOCUMENT_TYPES_CONSIGNMENT_NOTE")]
        ConsignmentNote = -5,
        /// <summary>
        /// Invoice.
        /// </summary>
        [Name("Invoice", "DOCUMENT_TYPES_INVOICE")]
        Invoice = -6,
        /// <summary>
        /// Work order.
        /// </summary>
        [Name("Work order", "DOCUMENT_TYPES_WORK_ORDER")]
        WorkOrder = -7,
    }
}
