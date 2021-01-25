using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Control message.
    /// </summary>
    [DataContract()]
    public class ControlMessage : MessageBase , IControlMessage
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ControlMessage() : base()
        { } 
        #endregion
    }
}
