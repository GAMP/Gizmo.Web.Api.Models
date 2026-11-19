using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Instance binding model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class InstanceBindingModel : IWebApiModel
    {
        /// <summary>
        /// Binding mode.
        /// </summary>
        [MessagePack.Key(0)]
        public InstanceBindingMode Mode { get; init; }

        /// <summary>
        /// Id of the portal instance this instance is bound to.
        /// </summary>
        /// <remarks>
        /// Only set when <see cref="Mode"/> is <see cref="InstanceBindingMode.Bound"/>.
        /// </remarks>
        [MessagePack.Key(1)]
        public Guid? InstanceId { get; init; }
    }
}
