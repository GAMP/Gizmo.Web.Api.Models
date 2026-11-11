namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User event message interface.
    /// </summary>
    /// <remarks>
    /// Messages of this family are delivered to the user events hub only.
    /// </remarks>
    public partial interface IUserEventMessage : IEventMessage
    {
    }
}
