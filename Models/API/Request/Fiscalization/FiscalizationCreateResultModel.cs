using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Fiscalization create result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class FiscalizationCreateResultModel : IWebApiModel
    {
        /// <summary>
        /// Results.
        /// </summary>
        [MessagePack.Key(0)]
        public IEnumerable<FiscalizationTaskResultModel> Results { get; set; } = Enumerable.Empty<FiscalizationTaskResultModel>();
    }
}
