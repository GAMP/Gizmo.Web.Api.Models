using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Device host relation model.
    /// </summary>
    [Serializable()]
    [MessagePackObject()]
    public class DeviceHost : DeviceHostModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// Gets object id. 
        /// </summary>
        [Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// Gets host id.
        /// </summary>
        [Key(101)]
        public int HostId
        {
            get; set;
        }

        #endregion
    }
}
