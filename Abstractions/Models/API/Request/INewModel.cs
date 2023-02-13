using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// New model.
    /// </summary>
    public interface INewModel : IWebApiModel
    {
        /// <summary>
        /// Gets or sets feed title.
        /// </summary>
        public string Title { get; init; }

        /// <summary>
        /// Gets or sets feed data.
        /// <remarks>
        /// Data can be set to plain text or html.
        /// </remarks>
        /// </summary>
        public string Data { get; init; }

        /// <summary>
        /// Gets or sets start date.
        /// </summary>
        public DateTime? StartDate { get; init; }

        /// <summary>
        /// Gets or sets end date.
        /// </summary>
        public DateTime? EndDate { get; init; }

        /// <summary>
        /// Gets external url string.
        /// </summary>
        public string Url { get; init; }

        /// <summary>
        /// Gets or sets media url string.
        /// </summary>
        public string MediaUrl { get; init; }

        /// <summary>
        /// Gets or sets new Id.
        /// </summary>
        public int Id { get; init; }
    }
}
