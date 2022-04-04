using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Order event message base.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public abstract class OrderEventMessageBase : APIEventMessage
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public OrderEventMessageBase() : base()
        { } 
        #endregion

        #region PROPERTIES
        /// <summary>
        /// Gets order id.
        /// </summary>
        [DataMember()]
        [Key(1)]
        public int OrderId { get; set; } 
        #endregion
    }
}
