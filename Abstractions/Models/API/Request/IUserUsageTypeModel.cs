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
        int AvailableMinutes { get; init; }

        /// <summary>
        /// 
        /// </summary>
        bool IsAvailable { get; init; }
        
        /// <summary>
        /// 
        /// </summary>
        DateTime? ActivationTime { get; init; }
    }
}
