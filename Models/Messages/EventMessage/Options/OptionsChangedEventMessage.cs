namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Options changed event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Changed", "OPTIONS_CHANGED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates options change", "OPTIONS_CHANGED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class OptionsChangedEventMessage : OptionsEventMessageBase
    {
        /// <inheritdoc/>
        public OptionsChangedEventMessage() : base() { }

        /// <summary>
        /// Gets option type.
        /// </summary>
        [MessagePack.Key(1)]
        public string OptionType { get; init; } = string.Empty;
    }
}
