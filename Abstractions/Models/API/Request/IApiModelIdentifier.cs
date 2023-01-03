namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Interface of base api model
    /// </summary>
    public interface IApiModelIdentifier
    {
        /// <summary>
        /// The Id of the object.
        /// </summary>
        int Id { get; set; }
    }
}