namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Options changed event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Change", "OPTIONS_CHANGE_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates options change", "OPTIONS_CHANGE_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class OptionsChangeEventMessage : OptionsEventMessageBase
    {
        /// <inheritdoc/>
        public OptionsChangeEventMessage() : base() { }

        /// <summary>
        /// Gets option type.
        /// </summary>
        [MessagePack.Key(1)]
        public string OptionType { get; init; } = string.Empty;
    }
}
