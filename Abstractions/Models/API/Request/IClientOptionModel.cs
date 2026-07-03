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

        /// <summary>
        /// Skin options.
        /// </summary>
        ClientOptionSkinModel? ClientOptionSkin { get; set; }

        /// <summary>
        /// Is default flag.
        /// </summary>
        bool IsDefault { get; set; }
    }
}
