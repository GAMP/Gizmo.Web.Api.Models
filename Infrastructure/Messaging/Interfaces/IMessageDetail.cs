using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Generic message detail interface.
    /// </summary>
    [Union(0, typeof(EntityMessageDetail))]
    [Union(1, typeof(BatchMessageDetail))]
    public interface IMessageDetail
    {
    }
}
