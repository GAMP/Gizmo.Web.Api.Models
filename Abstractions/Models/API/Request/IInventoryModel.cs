using System;
using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Inventory model.
    /// </summary>
    public interface IInventoryModel : IWebApiModel , IModelIntIdentifier
    {
        /// <summary>
        /// Gets or sets the stock id.
        /// </summary>
        public int StockId { get; }

        /// <summary>
        /// Gets or sets the shift id.
        /// </summary>
        public int? ShiftId { get; }

        /// <summary>
        /// Gets or sets note.
        /// </summary>
        public string? Note { get; }

        /// <summary>
        /// Gets associated documents.
        /// </summary>
        public IEnumerable<int> Documents { get; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        public DateTime Date { get; }

        /// <summary>
        /// Gets or sets the operator id.
        /// </summary>
        public int? OperatorId { get; init; }
    }
}
