using Gizmo.Web.Api.Models.Abstractions;
using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User session model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserSessionModel : IWebApiModel, IModelIntIdentifier
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Gets session user id.
        /// </summary>
        [MessagePack.Key(1)]
        public int UserId
        {
            get;init;
        }

        /// <summary>
        /// Gests session host id.
        /// </summary>
        [MessagePack.Key(2)]
        public int HostId
        {
            get;init;
        }

        /// <summary>
        /// Gets session slot.
        /// </summary>
        [MessagePack.Key(3)]
        public int Slot
        {
            get;init;
        }

        /// <summary>
        /// Gets session state.
        /// </summary>
        [MessagePack.Key(4)]
        public SessionState State
        {
            get;init;
        }

        /// <summary>
        /// Gets session span.
        /// </summary>
        [MessagePack.Key(5)]
        public double Span
        {
            get;init;
        }
    }
}
