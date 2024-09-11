namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Application application group.
    /// </summary>
    public interface IApplicationApplicationGroupModel : IWebApiModel
    {
        /// <summary>
        /// The Id of the application group the application belongs to.
        /// </summary>
        int ApplicationGroupId { get; set; }
    }
}
