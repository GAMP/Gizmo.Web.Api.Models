namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Ban reason.
    /// </summary>
    public interface IBanReasonModel : IWebApiModel
    {
        /// <summary>
        /// The name of the ban reason.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The description of the ban reason.
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Use order of the ban reason.
        /// </summary>
        int UseOrder { get; set; }
    }
}
