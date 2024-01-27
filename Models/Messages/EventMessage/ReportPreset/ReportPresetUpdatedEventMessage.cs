namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Report preset updated event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Report preset updated", "REPORT_PRESET_UPDATED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Report preset updated event", "REPORT_PRESET_UPDATED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class ReportPresetUpdatedEventMessage : ReportPresetEventMessageBase
    {
        /// <inheritdoc/>
        public ReportPresetUpdatedEventMessage():base()
        { }
    }
}
