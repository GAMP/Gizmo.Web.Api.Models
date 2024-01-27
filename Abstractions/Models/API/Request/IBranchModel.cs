using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Branch.
    /// </summary>
    public interface IBranchModel : IWebApiModel
    {
        /// <summary>
        /// Branch name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// City.
        /// </summary>
        public string? City { get; }

        /// <summary>
        /// Address.
        /// </summary>
        public string? Address { get; } 
        
        /// <summary>
        /// Phone.
        /// </summary>
        public string? Phone { get; }

        /// <summary>
        /// Email address.
        /// </summary>
        public string? Email { get; }

        /// <summary>
        /// Postal code.
        /// </summary>
        public string? PostalCode { get; }

        /// <summary>
        /// Region.
        /// </summary>
        public string? Region { get; }

        /// <summary>
        /// Web site url.
        /// </summary>
        public string? WebSite { get; }

        /// <summary>
        /// Info.
        /// </summary>
        public string? Info { get; }

        /// <summary>
        /// Branch time zone identifier.
        /// </summary>
        public string? TimeZone { get; }

        /// <summary>
        /// Indicates that branch is enabled.
        /// </summary>
        public bool IsEnabled { get; }

        /// <summary>
        /// Indicates that branch is deleted.
        /// </summary>
        public bool IsDeleted { get; }

        /// <summary>
        /// Global replication guid.
        /// </summary>
        public Guid Guid { get; }
    }
}
