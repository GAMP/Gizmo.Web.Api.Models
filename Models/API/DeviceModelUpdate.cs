using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Device update model.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject()]
    public class DeviceModelUpdate : DeviceModelBase, IEntityBase
    {
        #region PROPERTIES
        
        /// <inheritdoc/>
        [Key(3)]
        public int Id { get; set; } 

        #endregion
    }
}
