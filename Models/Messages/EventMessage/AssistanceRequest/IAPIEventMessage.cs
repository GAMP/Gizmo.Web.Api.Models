using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(900, typeof(AssistanceRequestCreatedMessage))]
    [Union(901, typeof(AssistanceRequestStatusChangeEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
