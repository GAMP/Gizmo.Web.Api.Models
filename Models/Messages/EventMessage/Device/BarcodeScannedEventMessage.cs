using System;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Barcode scanned event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Barcode scanned", "DEVICE_BARCODE_SCANNED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Barcode scanned event", "DEVICE_BARCODE_SCANNED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class BarcodeScannedEventMessage : DeviceEventMessageBase
    {
        /// <summary>
        /// Barcode data.
        /// </summary>
        [MessagePack.Key(1)]
        public byte[] Data { get; init; } = Array.Empty<byte>();
    }
}
