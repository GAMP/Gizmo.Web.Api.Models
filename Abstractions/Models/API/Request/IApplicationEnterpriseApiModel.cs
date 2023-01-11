namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Application enterprise.
    /// </summary>
    public interface IApplicationEnterpriseApiModel : IWebApiClientModel
    {
        /// <summary>
        /// The name of the enterprise.
        /// </summary>
        string Name { get; set; }
    }
}