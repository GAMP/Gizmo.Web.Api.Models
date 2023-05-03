using System;
using System.Collections.Generic;
using System.Linq;

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Model for the paginated data.
    /// </summary>
    /// <typeparam name="T">Data type.</typeparam>
    [Serializable, MessagePackObject]
    public sealed class PagedList<T>
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="data">Data.</param>
        public PagedList(IEnumerable<T> data)
        {
            Data = data;
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// The data of the current result set.
        /// </summary>
        [Key(0)]
        public IEnumerable<T> Data { get; } = Enumerable.Empty<T>();

        /// <summary>
        /// Cursor for the request of the next chunk of the records.
        /// </summary>
        [Key(1)]
        public PaginationCursor? NextCursor { get; set; }

        /// <summary>
        /// Cursor for the request of the previous chunk of the records.
        /// </summary>
        [Key(2)]
        public PaginationCursor? PrevCursor { get; set; }

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Set the cursor for the nex request.
        /// </summary>
        /// <param name="filter">Current filter for the request T entities.</param>
        public void SetCursor(IModelFilter filter)
        {
            if (filter.Pagination.Cursor is not null)
            {
                if (filter.Pagination.Cursor.IsForward)
                {
                    if (NextCursor is null)
                        NextCursor = filter.Pagination.Cursor;
                    else
                        filter.Pagination.Cursor = NextCursor;
                }
                else
                {
                    if (filter.Pagination.Cursor.Id == -1)
                        filter.Pagination.Cursor.Id = int.MaxValue;

                    if (PrevCursor is null)
                        PrevCursor = filter.Pagination.Cursor;
                    else
                        filter.Pagination.Cursor = PrevCursor;
                }
            }
            else
            {
                filter.Pagination.Cursor = NextCursor;
            }
        }

        #endregion
    }
}
