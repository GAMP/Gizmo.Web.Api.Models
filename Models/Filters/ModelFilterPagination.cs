using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Base filter for cursor-based pagination.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ModelFilterPagination
    {
        #region FIELDS

        private const int DEFAULT_LIMIT = 10;
        private const int MAX_LIMIT = 100;
        private int limit = DEFAULT_LIMIT;

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Return records after the specified Id.
        /// </summary>
        [Key(0)]
        public int? StartingAfter { get; set; }

        /// <summary>
        /// Return records before the specified Id.
        /// </summary>
        [Key(1)]
        public int? EndingBefore { get; set; }

        /// <summary>
        /// Limit the number of records to return. Limit can range between 1 and 100. The default value is 10.
        /// </summary>
        [Key(2)]
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

        [Key(3)]
        public string? Next { get; set; }

        [Key(4)]
        public string? Prev { get; set; }

        [Key(5)]
        public string? SortingFieldName { get; set; }
        #endregion
    }
}
