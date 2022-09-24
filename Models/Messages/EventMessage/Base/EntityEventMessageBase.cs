using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Entity event message base.
    /// </summary>
    [MessagePackObject()]
    public abstract class EntityEventMessageBase : APIEventMessage
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        public EntityEventMessageBase() : base()
        { }

        #endregion
    }
}
