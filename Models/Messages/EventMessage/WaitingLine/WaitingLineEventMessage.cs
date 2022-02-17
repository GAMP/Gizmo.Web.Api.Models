using MessagePack;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Waiting line event message.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public class WaitingLineEventMessage : WaitingLineEventMessageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public WaitingLineEventMessage() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets host group id.
        /// </summary>
        [DataMember()]
        [Key(1)]
        public int? HostGroupId
        {
            get; init;
        }

        /// <summary>
        /// Gets affected lines.
        /// </summary>
        [DataMember()]
        [Key(2)]
        public IEnumerable<WaitingLineStateModel> ActiveStates
        {
            get; init;
        }

        #endregion
    }
}
