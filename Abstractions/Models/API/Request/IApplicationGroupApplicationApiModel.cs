namespace Gizmo.Web.Api.Models.Abstractions.Models.API.Request
{
    /// <summary>
    /// Application group application.
    /// </summary>
    public interface IApplicationGroupApplicationApiModel
    {
        /// <summary>
        /// The Id of the application associated with this application group.
        /// </summary>
        int ApplicationId { get; set; }
    }
}