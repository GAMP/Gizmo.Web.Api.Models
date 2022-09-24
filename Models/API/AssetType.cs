using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Asset type.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class AssetType : AssetTypeModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(100)]
        public int Id { get; set; }

        #endregion
    }
}