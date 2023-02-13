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

        private const int DEFAULT_LIMIT = 1;
        private const int MAX_LIMIT = int.MaxValue;
        private int limit = DEFAULT_LIMIT;

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Limit records for the response. Default limit is 10. Max limit is 100.
        /// </summary>
        [Key(0)]
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

        /// <summary>
        /// Cursor for the next or previous chunk of the records.
        /// </summary>
        [Key(1)]
        public PaginationCursor? Cursor { get; set; }

        #endregion
    }
}
