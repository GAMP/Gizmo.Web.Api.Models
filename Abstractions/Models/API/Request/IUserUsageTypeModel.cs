using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// 
    /// </summary>
    public interface IUserUsageTypeModel
    {
        /// <summary>
        /// 
        /// </summary>
        public int UsageTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? OrderNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsAvailable { get; set; }
    }
}
