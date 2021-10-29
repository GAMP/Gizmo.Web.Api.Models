using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Waiting line event message interface.
    /// </summary>
    [Union(0,typeof(WaitingLineEventMessage))]
    public interface IWaitingLineEventMessage
    {
    }
}
