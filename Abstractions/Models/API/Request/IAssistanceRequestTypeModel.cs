namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Assistance request type.
    /// </summary>
    public interface IAssistanceRequestTypeModel : IWebApiModel
    {
        /// <summary>
        /// Title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Display order.
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Indicates that request type is delted.
        /// </summary>
        public bool IsDeleted { get; set; }

    }
}
