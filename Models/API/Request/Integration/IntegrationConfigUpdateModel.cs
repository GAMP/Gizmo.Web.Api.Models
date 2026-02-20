namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Integration configuration update model.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class IntegrationConfigUpdateModel : IWebApiModel
    {
        /// <summary>
        /// New configuration JSON, or <see langword="null"/> to clear all configuration values.
        /// </summary>
        [MessagePack.Key(0)]
        public string? ConfigJson { get; init; }

        /// <summary>
        /// Updated configuration schema version.
        /// </summary>
        [MessagePack.Key(1)]
        public int? ConfigSchemaVersion { get; init; }
    }
}
