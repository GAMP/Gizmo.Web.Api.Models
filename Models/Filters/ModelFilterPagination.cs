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

        [Key(1)]
        public PaginationCursor? Cursor { get; set; }

        #endregion
    }
}
