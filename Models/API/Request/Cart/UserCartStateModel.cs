using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User cart state model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserCartStateModel : IWebApiModel
    {
        /// <summary>
        /// User id.
        /// </summary>
        [MessagePack.Key(0)]
        public int UserId { get; set; }

        /// <summary>
        /// Entries.
        /// </summary>
        [MessagePack.Key(1)]
        public IEnumerable<CartEntryModel> Entries { get; set; } = Enumerable.Empty<CartEntryModel>();
    }
}
