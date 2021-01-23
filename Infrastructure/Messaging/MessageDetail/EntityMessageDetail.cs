using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Entity message detail.
    /// </summary>
    [DataContract()]
    public class EntityMessageDetail : MessageDetailBase
    {
         #region PROPERTIES

        /// <summary>
        /// Gets entity id.
        /// </summary>
        [DataMember(Order = 1)]
        public int EntityId
        {
            get; set;
        }

        /// <summary>
        /// Gets entity type name.
        /// </summary>
        [DataMember(Order = 2)]
        public string EntityType
        {
            get; set;
        }

        /// <summary>
        /// Gets event type.
        /// </summary>
        /// <remarks>
        /// This value identifies database operation such as create,delete,update etc.
        /// </remarks>
        [DataMember(Order = 3)]
        public int EventType
        {
            get; set;
        }

        #endregion
    }
}
