namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Waiting line event message base.
    /// </summary>
    public abstract class WaitingLineEventMessageBase : APIEventMessage
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public WaitingLineEventMessageBase() : base()
        {
        }
        #endregion
    }
}
