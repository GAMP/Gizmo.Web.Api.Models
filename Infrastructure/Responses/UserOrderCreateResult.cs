using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User order create result.
    /// </summary>
    [Serializable, MessagePackObject]
    public class UserOrderCreateResult
    {
        #region PROPERTIES
        
        /// <summary>
        /// The Id of the newly created object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; } 

        #endregion
    }
}
