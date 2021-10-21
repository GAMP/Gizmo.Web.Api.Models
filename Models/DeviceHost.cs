using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Device host relation model.
    /// </summary>
    [Serializable()]
    [DataContract]
    public class DeviceHost : IEntityBase
    {
        #region PROPERTIES
        
        /// <summary>
        /// Gets object id. 
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Gets host id.
        /// </summary>
        [DataMember]
        public int HostId
        {
            get; set;
        }

        /// <summary>
        /// Gets device id.
        /// </summary>
        [DataMember]
        public int DeviceId
        {
            get; set;
        } 

        #endregion
    }
}
