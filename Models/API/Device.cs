using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Device model.
    /// </summary>
    [Serializable]
    [MessagePackObject()]
    public class Device : DeviceModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// Gets device id.
        /// </summary>
        [Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// Gets device type.
        /// </summary>
        [Key(101)]
        public DeviceType DeviceType { get; set; }

        #endregion
    }
}
