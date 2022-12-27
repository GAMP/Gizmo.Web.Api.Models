namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Request
{
    /// <summary>
    /// Asset type.
    /// </summary>
    public interface IAssetTypeApiModel
    {
        /// <summary>
        /// The description of the asset type.
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// The name of the asset type.
        /// </summary>
        string Name { get; set; }
    }
}