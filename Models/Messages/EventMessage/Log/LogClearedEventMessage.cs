namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Log cleared event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Cleared", "LOG_CLEARED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates log being cleared", "LOG_CLEARED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class LogClearedEventMessage : LogEventMessageBase
    {
    }
}
