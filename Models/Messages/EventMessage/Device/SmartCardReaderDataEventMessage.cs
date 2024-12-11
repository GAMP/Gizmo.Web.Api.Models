using System;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Smart card reader data event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Smartcard reader data event", "DEVICE_SMART_CARD_READER_DATA_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Smartcard reader data event", "DEVICE_SMART_CARD_READER_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class SmartCardReaderDataEventMessage : DeviceEventMessageBase
    {
        /// <summary>
        /// Event data.
        /// </summary>
        [MessagePack.Key(1)]
        public byte[] Data { get; init; } = Array.Empty<byte>();
    }
}
