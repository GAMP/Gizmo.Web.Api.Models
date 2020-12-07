using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Command message.
    /// </summary>
    [DataContract()]
    [JsonConverter(typeof(MessageJsonConverter))]
    public class CommandMessage : MessageBase
    {
        #region CONSTRUCTOR
        
        public CommandMessage() : base()
        { } 

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets command correlation id.
        /// </summary>
        [DataMember(Order = 1)]
        public string CorellationId
        {
            get; set;
        } 

        /// <summary>
        /// Gets server timeout.
        /// </summary>
        [DataMember(Order = 2)]
        public int? ServerTimeout
        {
            get;set;
        }

        #endregion
    }
}
