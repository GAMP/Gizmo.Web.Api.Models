using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Result of listing the portal instances this instance can be bound to.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PortalInstancesResultModel : IWebApiModel
    {
        /// <summary>
        /// Result code.
        /// </summary>
        [MessagePack.Key(0)]
        public InstanceBindingResultCodes Result { get; init; }

        /// <summary>
        /// Portal instances, empty unless the result is <see cref="InstanceBindingResultCodes.Success"/>.
        /// </summary>
        [MessagePack.Key(1)]
        public PortalInstanceModel[] Instances { get; init; } = Array.Empty<PortalInstanceModel>();
    }
}
