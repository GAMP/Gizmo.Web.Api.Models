using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Close balance payments state create model
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class CloseBalancePaymentsStateCreateModel : IWebApiModel
    {
        /// <summary>
        /// Invoices.
        /// </summary>
        [MessagePack.Key(0)]
        public required IEnumerable<int> Invoices { get; init; }
    }
}
