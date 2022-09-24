using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Point transaction model base.
    /// </summary>
    [Serializable()]
    [MessagePackObject()]
    public abstract class PointTransactionModelBase
    {
        #region PROPERTIES  

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [Key(0)]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets transaction type.
        /// </summary>
        [Key(1)]
        public PointsTransactionType Type
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets amount.
        /// </summary>
        [Key(2)]
        public int Amount
        {
            get;set;
        }

        #endregion
    }
}
