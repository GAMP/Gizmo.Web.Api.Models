using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Entity event message base.
    /// </summary>
    [DataContract()]
    [MessagePackObject()] 
    public abstract class EntityEventMessageBase : EventMessage, IEntityEventMessage
    {
        #region CONSTRUCTOR
        
        /// <summary>
        /// Creates new instance.
        /// </summary>
         public EntityEventMessageBase() : base(EventMessageTypeCache.IEntityEventMessage)
        { } 

        #endregion
    }
}
