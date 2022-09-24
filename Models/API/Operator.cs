using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Operator.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class Operator : OperatorModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The GUID of the operator.
        /// </summary>
        [Key(101)]
        public Guid Guid { get; set; }

        #endregion
    }
}
