using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Point transaction model base.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [MessagePackObject()]
    public abstract class PointTransactionModelBase
    {
        #region PROPERTIES  

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [Key(0)]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets transaction type.
        /// </summary>
        [DataMember()]
        [Key(1)]
        public PointsTransactionType Type
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets amount.
        /// </summary>
        [DataMember()]
        [Key(2)]
        public int Amount
        {
            get;set;
        }

        #endregion
    }
}
