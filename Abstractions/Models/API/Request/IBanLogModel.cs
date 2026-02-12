using System;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Ban log model.
    /// </summary>
    public interface IBanLogModel : IWebApiModel, IModelIntIdentifier
    {
        /// <summary>
        /// User id.
        /// </summary>
        public int UserId { get; init; }

        /// <summary>
        /// Type.
        /// </summary>
        public UserMemberDisableEntryType Type { get; init; }

        /// <summary>
        /// Ban reason id.
        /// </summary>
        public int? BanReasonId { get; init; }

        /// <summary>
        /// Note.
        /// </summary>
        public string? Note { get; init; }

        /// <summary>
        /// Time.
        /// </summary>
        public DateTime Time { get; init; }

        /// <summary>
        /// Enabled time.
        /// </summary>
        public DateTime? EnableDate { get; init; }

        /// <summary>
        /// Operator id.
        /// </summary>
        public int? OperatorId { get; init; }
    }
}
