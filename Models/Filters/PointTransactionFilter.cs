using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Point transaction filter class.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [MessagePackObject]
    public class PointTransactionFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// Return points transactions where the date greater than or equal to the specified date.
        /// </summary>
        [DataMember]
        [MessagePack.Key(200)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return points transactions where the date less than or equal to the specified date.
        /// </summary>
        [DataMember]
        [MessagePack.Key(201)]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Return points transactions of the specified user.
        /// </summary>
        [DataMember]
        [MessagePack.Key(202)]
        public int? UserId { get; set; }

        /// <summary>
        /// Return points transaction of specified type.
        /// </summary>
        [DataMember]
        [MessagePack.Key(203)]
        public PointsTransactionType? Type
        {
            get;init;
        }

        #endregion
    }
}
