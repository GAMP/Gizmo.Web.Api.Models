using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Device update model.
    /// </summary>
    [Serializable]
    [MessagePackObject()]
    public class DeviceModelUpdate : DeviceModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <inheritdoc/>
        [Key(100)]
        public int Id { get; set; } 

        #endregion
    }
}
