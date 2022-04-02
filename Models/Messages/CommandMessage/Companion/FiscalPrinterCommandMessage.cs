namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Device command message.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class FiscalPrinterCommandMessage : CommandMessage
    {
        public object Payload { get; set; }
    }
}
