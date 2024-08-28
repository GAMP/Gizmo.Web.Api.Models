namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Application link.
    /// </summary>
    public interface IApplicationLinkModel : IWebApiModel
    {
        /// <summary>
        /// The Id of the application this link belongs to.
        /// </summary>
        int ApplicationId { get; set; }

        /// <summary>
        /// The caption of the link.
        /// </summary>
        string? Caption { get; set; }

        /// <summary>
        /// The description of the link.
        /// </summary>
        string? Description { get; set; }

        /// <summary>
        /// The URL of the link.
        /// </summary>
        string? Url { get; set; }

        /// <summary>
        /// The display order of the link.
        /// </summary>
        int DisplayOrder { get; set; }
    }
}
