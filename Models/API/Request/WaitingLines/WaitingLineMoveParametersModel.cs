using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Waiting line entry move parameters model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class WaitingLineMoveParametersModel : IWebApiModel
    {
        /// <summary>
        /// Move type.
        /// </summary>
        [MessagePack.Key(0)]
        public WaitingLineMoveType MoveType { get; init; }

        /// <summary>
        /// Custom position.
        /// </summary>
        /// <remarks>This value will only have effect if <see cref="MoveType"/> is set to <see cref="WaitingLineMoveType.Custom"/>.</remarks>
        [MessagePack.Key(1)]
        public int? Position { get; init; }
    }
}
