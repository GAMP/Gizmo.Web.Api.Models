namespace Gizmo.Web.Api.Messaging
{
    [MessagePack.Union(2001,typeof(LogClearedEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
