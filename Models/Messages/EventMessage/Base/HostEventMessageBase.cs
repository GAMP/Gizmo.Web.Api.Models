using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Host event message base.
    /// </summary>
    [MessagePackObject()]
    public abstract class HostEventMessageBase : APIEventMessage
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
        public int HostId
        {
            get; init;
        } 

        #endregion
    }
}
