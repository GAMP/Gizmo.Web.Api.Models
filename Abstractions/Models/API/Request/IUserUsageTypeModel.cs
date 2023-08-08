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
        int UsageTypeId { get; init; }
        
        /// <summary>
        /// 
        /// </summary>
        int AvailableMinutes { get; init; }
        
        /// <summary>
        /// 
        /// </summary>
        int UsableMinutes { get; init; }
        
        /// <summary>
        /// 
        /// </summary>
        DateTime UntilTime { get; init; }
    }
}
