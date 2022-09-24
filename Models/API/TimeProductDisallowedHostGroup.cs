using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Time product disallowed host group.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class TimeProductDisallowedHostGroup : TimeProductDisallowedHostGroupModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the time product.
        /// </summary>
        [Key(101)]
        public int TimeProductId { get; set; }

        #endregion
    }
}