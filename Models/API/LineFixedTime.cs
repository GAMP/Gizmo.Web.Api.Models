using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Line fixed time.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class LineFixedTime : IUrlQueryParameters
    {
        #region PROPERTIES
        
        /// <summary>
        /// The quantity type of the fixed time line.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(0)]
        public FixedTimeQuantityType QuantityType { get; set; } 

        #endregion
    }
}