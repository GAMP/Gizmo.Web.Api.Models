using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Instance binding parameters.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class InstanceBindingParametersModel : IWebApiModel
    {
        /// <summary>
        /// Id of the portal instance to bind to.
        /// </summary>
        [MessagePack.Key(0)]
        public Guid InstanceId { get; init; }
    }
}
