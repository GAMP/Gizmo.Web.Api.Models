namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Client option.
    /// </summary>
    public interface IClientOptionModel : IWebApiModel
    {
        /// <summary>
        /// The name of the client option.
        /// </summary>
        string Name { get; set; }

        ClientOptionSkinModel? ClientOptionSkin { get; set; }

        string? CustomCSS { get; set; }
    }
}
