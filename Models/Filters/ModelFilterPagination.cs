﻿using System;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Pagination model by cursor pagination.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ModelFilterPagination
    {
        #region FIELDS

        private const int DefaultLimit = 10;
        private int _limit = DefaultLimit;

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Limit records for the response.
        ///  equal 0 => DefaultLimit;
        ///  equal -1 => int.MaxValue;
        ///  less then -1 => DefaultLimit;
        ///  Default limit is 10.
        /// </summary>
        [Key(0)]
        public int Limit
        {
            get => _limit;
            set => _limit = value switch
            {
                < -1 => DefaultLimit,
                -1 => int.MaxValue - 1,
                0 => DefaultLimit,
                int.MaxValue => int.MaxValue - 1,
                _ => value
            };
        }

        /// <summary>
        /// Cursor for the request.
        /// </summary>
        [Key(1)]
        public PaginationCursor? Cursor { get; set; }

        #endregion
    }
}
