namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User usage session model.
    /// </summary>
    public interface IUserUsageSessionModel : IWebApiModel
    {
        /// <summary>
        /// Usage session id.
        /// </summary>
        public int UsageSessionId { get; init; }

        /// <summary>
        /// User id.
        /// </summary>
        public int UserId { get; init; }

        /// <summary>
        /// Product name.
        /// </summary>
        public string? TimeProduct { get; init; }

        /// <summary>
        /// Current usage type.
        /// </summary>
        public UsageType CurrentUsageType { get; init; }
    }
}
