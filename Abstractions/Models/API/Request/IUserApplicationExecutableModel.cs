namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User application executable model.
    /// </summary>
    public interface IUserApplicationExecutableModel : IWebApiModel
    {
        /// <summary>
        /// The Id of the application this executable belongs to.
        /// </summary>
        int ApplicationId { get; set; }

        /// <summary>
        /// The caption of the executable.
        /// </summary>
        string? Caption { get; set; }

        /// <summary>
        /// The description of the executable.
        /// </summary>
        string? Description { get; set; }

        /// <summary>
        /// The display order of the executable.
        /// </summary>
        int DisplayOrder { get; set; }
    }
}
