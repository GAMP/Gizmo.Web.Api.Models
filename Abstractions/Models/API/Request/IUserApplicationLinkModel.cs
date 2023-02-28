namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User application link model.
    /// </summary>
    public interface IUserApplicationLinkModel : IWebApiModel
    {
        /// <summary>
        /// The caption of the link.
        /// </summary>
        string Caption { get; init; }

        /// <summary>
        /// The caption of the link.
        /// </summary>
        string Description { get; init; }

        /// <summary>
        /// The caption of the link.
        /// </summary>
        string Url { get; init; }

        /// <summary>
        /// The caption of the link.
        /// </summary>
        int DisplayOrder { get; init; }
    }
}
