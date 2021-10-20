using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Device update model.
    /// </summary>
    [Serializable]
    [DataContract]
    public class DeviceModelUpdate : DeviceModelBase, IEntityBase
    {
        #region PROPERTIES
        
        /// <inheritdoc/>
        public int Id { get; set; } 

        #endregion
    }
}
