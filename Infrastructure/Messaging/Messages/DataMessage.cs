using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Detailed message.
    /// </summary>
    [DataContract()]
    public class DataMessage : MessageBase, IDataMessage
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="detail">Message detail</param>
        public DataMessage(IMessageDetail detail) : this()
        {
            Detail = detail;
        }

        /// <summary>
        /// <inheritdoc cref="DataMessage(IMessageDetail)"/>
        /// </summary>
        public DataMessage() : base()
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
