using System;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Base filter for cursor-based pagination.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ModelFilterPagination
    {
        #region FIELDS

        private const int DefaultLimit = 10;

        private int limit = DefaultLimit;

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Limit records for the response. Default limit is 10.
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
                limit = value switch
                {
                    0 => DefaultLimit,
                    -1 => int.MaxValue,
                    < -1 => DefaultLimit,
                    _ => value
                };
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
