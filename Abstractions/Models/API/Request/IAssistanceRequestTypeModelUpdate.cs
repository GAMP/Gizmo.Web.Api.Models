namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Assistance request type update model.
    /// </summary>
    public interface IAssistanceRequestTypeModelUpdate : IWebApiModel
    {
        /// <summary>
        /// Display order.
        /// </summary>
        public int? DisplayOrder { get; set; }

        /// <summary>
        /// Title.
        /// </summary>
        public string? Title { get; set; } 
    }
}
