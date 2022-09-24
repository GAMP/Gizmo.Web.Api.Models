using MessagePack;
using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Base filter for cursor-based pagination.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class GetOptions : IUrlQueryParameters
    {
        #region PROPERTIES
        
        /// <summary>
        /// Include specified objects in the result.
        /// </summary>
        [Key(0)]
        public List<string> Expand { get; set; } 

        #endregion
    }
}