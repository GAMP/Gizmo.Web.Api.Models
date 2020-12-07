using MessagePack;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Generic message interface.
    /// </summary>
    [Union(0, typeof(IDetailedMessage))]
    [Union(1, typeof(DetailedMessage))]
    public interface IMessage
    {
        #region PROPERTIES

        /// <summary>
        /// Gets message version.
        /// </summary>
        public int Version { get; }

        #endregion
    }
}
