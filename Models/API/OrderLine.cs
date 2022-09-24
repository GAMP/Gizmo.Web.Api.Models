using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order line.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class OrderLine : OrderLineModelBase, IEntityBase
    {
        #region PROPERTIES
        
        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(100)]
        public int Id { get; set; } 

        #endregion
    }
}