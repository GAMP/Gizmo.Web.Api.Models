using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application personal file.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationPersonalFile : ApplicationPersonalFileModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The GUID of the application personal file.
        /// </summary>
        [Key(101)]
        public Guid Guid { get; set; }

        #endregion
    }
}
