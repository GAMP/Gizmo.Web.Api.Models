using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User event message base.
    /// </summary>
    [MessagePackObject()]
    public abstract class UserEventMessageBase : APIEventMessage
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserEventMessageBase() : base()
        { } 
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets user id.
        /// </summary>
        [Key(1)]
        public int UserId
        {
            get; set;
        } 

        #endregion
    }
}
