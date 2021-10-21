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
    public class DeviceHost : IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// Gets object id. 
        /// </summary>
        [DataMember]
        [Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// Gets host id.
        /// </summary>
        [DataMember]
        [Key(1)]
        public int HostId
        {
            get; set;
        }

        /// <summary>
        /// Gets device id.
        /// </summary>
        [DataMember]
        [Key(2)]
        public int DeviceId
        {
            get; set;
        }

        #endregion
    }
}
