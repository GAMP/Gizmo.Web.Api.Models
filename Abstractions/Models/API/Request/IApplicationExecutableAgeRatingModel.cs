namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Application executable model age rating.
    /// </summary>
    public interface IApplicationExecutableAgeRatingModel : IWebApiModel
    {
        
        /// <summary>
        /// Executable path of an application.
        /// </summary>
        string ExecutablePath { get; set; }

        /// <summary>
        /// Age rating of an application.
        /// </summary>
        int AgeRating { get; set; }
    }
}
