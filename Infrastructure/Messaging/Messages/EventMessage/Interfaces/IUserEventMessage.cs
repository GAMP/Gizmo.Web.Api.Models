using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User event message.
    /// </summary>
    [Union(0,typeof(UserBalanceChangeEventMessage))]
    public interface IUserEventMessage : IEventMessage
    {
    }
}
