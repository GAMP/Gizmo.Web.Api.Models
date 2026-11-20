using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// A model selectable on an AI connection.
    /// </summary>
    [MessagePackObject]
    public sealed class AiModelDescriptorModel : IWebApiModel
    {
        /// <summary>
        /// Opaque model identifier understood by the connection's provider.
        /// </summary>
        [Key(0)]
        public string ModelId { get; init; } = string.Empty;

        /// <summary>
        /// Display name of the model.
        /// </summary>
        [Key(1)]
        public string DisplayName { get; init; } = string.Empty;
    }
}
