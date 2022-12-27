namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Request
{
    /// <summary>
    /// Application group.
    /// </summary>
    public interface IApplicationGroupApiModel
    {
        /// <summary>
        /// The name of the application group.
        /// </summary>
        string Name { get; set; }
    }
}