namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Report preset event message base.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Report preset", "REPORT_PRESET_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Report preset related events", "REPORT_PRESET_EVENT_GROUP_DESCRIPTION")]
    [EventGroup(12)]
    public abstract class ReportPresetEventMessageBase : APIEventMessage
    {
        /// <inheritdoc/>
        public ReportPresetEventMessageBase() : base()
        { }

        /// <summary>
        /// Gets report preset id.
        /// </summary>
        [MessagePack.Key(1)]
        public int ReportPresetId { get; init; }
    }
}
