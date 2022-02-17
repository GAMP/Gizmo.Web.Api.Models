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
    public class DeviceHostModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// Gets device id.
        /// </summary>
        [DataMember]
        [Key(0)]
        public int DeviceId
        {
            get; set;
        }

        #endregion
    }
}
