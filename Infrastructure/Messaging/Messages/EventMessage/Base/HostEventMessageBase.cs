using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Host event message base.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public abstract class HostEventMessageBase : EventMessage
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public HostEventMessageBase() : base()
        { } 
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets host id.
        /// </summary>
        [Key(1)]
        [DataMember()]
        public int HostId
        {
            get; init;
        } 

        #endregion
    }
}
