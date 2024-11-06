namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Companion model.
    /// </summary>
    public interface ICompanionModel : IWebApiModel
    {
        /// <summary>
        /// Name.
        /// </summary>
        string Name { get; set; }
    }
}
