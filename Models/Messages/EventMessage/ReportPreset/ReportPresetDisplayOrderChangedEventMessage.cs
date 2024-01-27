namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Report preset display order changed event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Report preset display order changed", "REPORT_PRESET_ADDED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Report preset display order changed event", "REPORT_PRESET_ADDED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class ReportPresetDisplayOrderChangedEventMessage : ReportPresetEventMessageBase
    {
        /// <summary>
        /// Gets new display order.
        /// </summary>
        public int DisplayOrder { get; init; }
    }
}
