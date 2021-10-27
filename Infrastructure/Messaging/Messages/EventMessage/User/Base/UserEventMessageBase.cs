using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User event message base.
    /// </summary>
    [DataContract()]
    public abstract class UserEventMessageBase : EventMessage, IUserEventMessage
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserEventMessageBase() : base(EventMessageTypeCache.IUserEventMessage)
        { } 
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets user id.
        /// </summary>
        [DataMember()]
        [Key(1)]
        public int UserId
        {
            get; set;
        } 

        #endregion
    }
}
