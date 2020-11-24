using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Base filter for cursor-based pagination.
    /// </summary>
    [Serializable]
    [DataContract]
    public class PaginationFilter
    {
        private const int DEFAULT_LIMIT = 10;
        private const int MAX_LIMIT = 100;

        private int limit = DEFAULT_LIMIT;

        /// <summary>
        /// Return records after the specified Id.
        /// </summary>
        [DataMember]
        public int? StartingAfter { get; set; }

        /// <summary>
        /// Return records before the specified Id.
        /// </summary>
        [DataMember]
        public int? EndingBefore { get; set; }

        /// <summary>
        /// Limit the number of records to return. Limit can range between 1 and 100. The default values is 10.
        /// </summary>
        [DataMember]
        public int Limit
        {
            get
            {
                return limit;
            }
            set
            {
                if (value <= 0)
                    limit = DEFAULT_LIMIT;

                if (value > MAX_LIMIT)
                    limit = MAX_LIMIT;

                if (value > 0 && value <= MAX_LIMIT)
                    limit = value;
            }
        }
    }
}