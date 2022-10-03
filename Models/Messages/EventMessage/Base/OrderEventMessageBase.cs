using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Order event message base.
    /// </summary>
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
        [Key(1)]
        public int OrderId { get; set; } 

        #endregion
    }
}
