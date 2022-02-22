using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for stock transactions.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class StockTransactionsFilter : PaginationFilter, IUrlQueryParameters
    {
        /// <summary>
        /// Return stock transactions where the date greater than or equal to the specified date.
        /// </summary>
        [DataMember]
        [MessagePack.Key(200)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Return stock transactions where the date less than or equal to the specified date.
        /// </summary>
        [DataMember]
        [MessagePack.Key(201)]
        public DateTime? DateTo { get; set; }
    }
}
