namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Payment terminal error event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Error", "DEVICE_PAYMENT_TERMINAL_ERROR_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Payment terminal error event", "DEVICE_PAYMENT_TERMINAL_ERROR_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class PaymentTerminalErrorEventMessage : DeviceEventMessageBase
    {
        /// <summary>
        /// Error message.
        /// </summary>
        [MessagePack.Key(1)]
        public string Message { get; init; } = null!;
    }
}
