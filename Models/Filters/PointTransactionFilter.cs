using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Point transaction filter class.
    /// </summary>
    [Serializable()]
    [MessagePackObject]
    public class PointTransactionFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// Return points transactions where the date greater than or equal to the specified date.
        /// </summary>
        [Key(200)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return points transactions where the date less than or equal to the specified date.
        /// </summary>
        [Key(201)]
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Return points transactions of the specified user.
        /// </summary>
        [Key(202)]
        public int? UserId { get; set; }

        /// <summary>
        /// Return points transaction of specified type.
        /// </summary>
        [Key(203)]
        public PointsTransactionType? Type
        {
            get;init;
        }

        #endregion
    }
}
