using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Message detail interface.
    /// </summary>
    [Union(0, typeof(EntityMessageDetail))]
    [Union(1, typeof(BatchMessageDetail))]
    [Union(2, typeof(UserEventMessageDetail))]
    public interface IMessageDetail
    {
    }
}
