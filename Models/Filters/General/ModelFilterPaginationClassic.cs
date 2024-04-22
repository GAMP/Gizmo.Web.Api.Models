using System;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Pagination model by classic pagination.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ModelFilterPaginationClassic
    {
        /// <summary>
        /// All records.
        /// </summary>
        public static readonly ModelFilterPaginationClassic DefaultUnlimited = new() { PageNumber = 1, PageSize = -1 };
        
        #region FIELDS

        private const int DefaultPageSize = 10;
        private int _pageSize = DefaultPageSize;

        private const int DefaultPageNumber = 1;
        private int _pageNumber = DefaultPageNumber;

        #endregion
        #region PROPERTIES

        ///<summary>
        /// Gets or sets the page number.
        /// less then 1 or equal int.MaxValue => DefaultPageNumber;
        /// Default page number is 1.
        /// </summary>
        [Key(0)]
        public int PageNumber
        {
            get => _pageNumber;
            set => _pageNumber = value switch
            {
                < 1 => DefaultPageNumber,
                int.MaxValue => DefaultPageNumber,
                _ => value
            };
        }

        ///<summary>
        /// Gets or sets the page size.
        /// equal -1 => int.MaxValue;
        /// less then -1 or equal 0 => DefaultPageSize;
        /// Default page size is 10. 
        /// </summary>
        [Key(1)]
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = value switch
            {
                < -1 => DefaultPageSize,
                -1 => int.MaxValue - 1,
                0 => DefaultPageSize,
                int.MaxValue => int.MaxValue - 1,
                _ => value
            };
        }

        #endregion
    }
}
