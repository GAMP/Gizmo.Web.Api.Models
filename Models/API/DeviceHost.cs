using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Device host relation model.
    /// </summary>
    [Serializable()]
    [DataContract]
    [MessagePackObject()]
    public class DeviceHost : DeviceHostModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// Gets object id. 
        /// </summary>
        [DataMember]
        [Key(1)]
        public int Id { get; set; }

        /// <summary>
        /// Gets host id.
        /// </summary>
        [DataMember]
        [Key(2)]
        public int HostId
        {
            get; set;
        }

        #endregion
    }
}
