namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Fiscal printer error event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Error", "DEVICE_FISCAL_PRINTER_ERROR_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Fiscal printer error event", "DEVICE_FISCAL_PRINTER_ERROR_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class FiscalPrinterErrorEventMessage : DeviceEventMessageBase
    {
        /// <summary>
        /// Error message.
        /// </summary>
        [MessagePack.Key(1)]
        public string Message { get; init; } = null!;
    }
}
