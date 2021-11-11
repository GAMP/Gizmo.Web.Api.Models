namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Generic event message wrapper.
    /// </summary>
    public class EventDescriptor
    {
        #region PROPERTIES

        /// <summary>
        /// Gets event instance.
        /// </summary>
        public IEventMessage Event { get; init; }

        #endregion
    }
}
