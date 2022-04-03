using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Device command message.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class FiscalPrinterCommandMessage : CommandMessage
    {
        [Key(0)]
        public object Payload { get; set; }
    }
}
