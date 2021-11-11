using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Entity change event message.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public class EntityChangeEventMessage : EntityEventMessageBase
    {
        #region PROPERTIES

        /// <summary>
        /// Gets entity id.
        /// </summary>
        [DataMember(Order = 1)]
        [Key(1)]
        public int EntityId
        {
            get; set;
        }

        /// <summary>
        /// Gets event type.
        /// </summary>
        /// <remarks>
        /// This value identifies database operation such as create,delete,update etc.
        /// </remarks>
        [DataMember(Order = 2)]
        [Key(2)]
        public EntityEventType EventType
        {
            get; set;
        }

        /// <summary>
        /// Gets entity type name.
        /// </summary>
        [DataMember(Order = 3)]
        [Key(3)]
        public string EntityType
        {
            get; set;
        }

        #endregion
    }  
}
