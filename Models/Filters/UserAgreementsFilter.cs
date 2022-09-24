using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for user agreements.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class UserAgreementsFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// Return enabled user agreements.
        /// </summary>
        [Key(200)]
        public bool? IsEnabled { get; set; } 
        
        #endregion
    }
}