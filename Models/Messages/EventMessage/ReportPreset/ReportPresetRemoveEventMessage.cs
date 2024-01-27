namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Report preset removed event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Report preset removed", "REPORT_PRESET_REMOVED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Report preset removed event", "REPORT_PRESET_REMOVED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class ReportPresetRemoveEventMessage : ReportPresetEventMessageBase
    {
    }
}
