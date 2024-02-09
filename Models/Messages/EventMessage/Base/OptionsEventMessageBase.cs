namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Options event message base.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Options", "OPTIONS_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Options related events", "OPTIONS_EVENT_GROUP_DESCRIPTION")]
    [EventGroup(13)]
    public abstract class OptionsEventMessageBase : APIEventMessage
    {
        /// <inheritdoc/>
        public OptionsEventMessageBase() : base()
        { }
    }
}
