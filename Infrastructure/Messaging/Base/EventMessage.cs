using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Event base message.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public class EventMessage : SerializationTypeMessage, IEventMessage
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        public EventMessage() : base(IEventMessage)
        { }

        #endregion
    }  
}
