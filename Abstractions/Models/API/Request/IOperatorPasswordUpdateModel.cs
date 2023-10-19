namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Operator password update mode.
    /// </summary>
    public interface IOperatorPasswordUpdateModel : IWebApiModel 
    {
        /// <summary>
        /// New password.
        /// </summary>
        public string Password { get; init; }        
    }
}
