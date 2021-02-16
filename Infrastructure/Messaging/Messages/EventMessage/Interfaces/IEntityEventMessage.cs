using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Entity event message interface.
    /// </summary>
    [Union(0, typeof(EntityChangeEventMessage))]
    public interface IEntityEventMessage : IEventMessage
    {
    }
}
