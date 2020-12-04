using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Detailed message.
    /// </summary>
    [DataContract()]
    [JsonConverter(typeof(MessageJsonConverter))]
    public class DetailedMessage : MessageBase, IDetailedMessage
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="detail">Message detail</param>
        public DetailedMessage(IMessageDetail detail)
        {
            Detail = detail;
        }

        /// <summary>
        /// <inheritdoc cref="DetailedMessage(IMessageDetail)"/>
        /// </summary>
        public DetailedMessage() : base()
        {
        }

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets message detail.
        /// </summary>
        [DataMember(Order = 1)]
        public IMessageDetail Detail
        {
            get; set;
        }

        #endregion
    }
}
