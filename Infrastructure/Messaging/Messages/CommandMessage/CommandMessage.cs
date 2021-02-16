using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Command message.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public class CommandMessage : MessageBase
    {
        #region CONSTRUCTOR
        
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public CommandMessage() : base()
        { } 

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets command correlation id.
        /// </summary>
        [DataMember(Order = 2,IsRequired =false)]
        public string CorellationId
        {
            get; set;
        } 

        /// <summary>
        /// Gets server timeout.
        /// </summary>
        [DataMember(Order = 3,IsRequired =false)]
        public int? ServerTimeout
        {
            get;set;
        }

        #endregion
    }
}
