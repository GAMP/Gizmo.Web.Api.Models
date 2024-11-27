namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Api key create result.
    /// </summary>
    public sealed class ApiKeyCreateResult : CreateResult
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <param name="apiKey">Api key.</param>
        public ApiKeyCreateResult(int id, string apiKey)
            : base(id)
        {
            ApiKey = apiKey;
        }

        /// <summary>
        /// Gets api key.
        /// </summary>
        [MessagePack.Key(1)]
        public string ApiKey { get; }
    }
}
