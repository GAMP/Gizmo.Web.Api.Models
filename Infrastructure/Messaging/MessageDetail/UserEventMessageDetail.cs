using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User event message detail.
    /// </summary>
    [DataContract()]
    public class UserEventMessageDetail : MessageDetailBase
    {
        #region PROPERTIES
        
        /// <summary>
        /// Gets user id.
        /// </summary>
        public int UserId
        {
            get; set;
        } 

        #endregion
    }
}
