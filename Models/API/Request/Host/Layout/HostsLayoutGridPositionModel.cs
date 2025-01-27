using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    [MessagePack.MessagePackObject()]
    public sealed class HostsLayoutGridPositionModel : IWebApiModel
    {
        [MessagePack.Key(0)]
        public IEnumerable<HostLayoutGridPositionModel> Hosts { get; set; } = Enumerable.Empty<HostLayoutGridPositionModel>();
    }
}
