namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User product group model.
    /// </summary>
    public interface IUserProductGroupModel : IWebApiModel
    {
        /// <summary>
        /// The name of the product group.
        /// </summary>
        string Name { get; set; }
    }
}
