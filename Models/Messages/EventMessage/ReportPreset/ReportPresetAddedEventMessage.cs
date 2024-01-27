namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Report preset added event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Report preset added", "REPORT_PRESET_ADDED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Report preset added event", "REPORT_PRESET_ADDED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class ReportPresetAddedEventMessage : ReportPresetEventMessageBase
    {
        /// <inheritdoc/>
        public ReportPresetAddedEventMessage() :base()
        { }
    }
}
