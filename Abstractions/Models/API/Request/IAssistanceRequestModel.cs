using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Assistance request.
    /// </summary>
    public interface IAssistanceRequestModel : IWebApiModel
    {
        /// <summary>
        /// Request type id.
        /// </summary>
        public int AssistanceRequestTypeId { get; set; }

        /// <summary>
        /// Requesting user id.
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Host id.
        /// </summary>
        public int HostId { get; set; }

        /// <summary>
        /// Status.
        /// </summary>
        public AssistanceRequestStatus Status { get; set; }

        /// <summary>
        /// Note.
        /// </summary>
        public string? Note { get; set; }

        /// <summary>
        /// Created time.
        /// </summary>
        public DateTime CreatedTime { get; set; }
    }
}
