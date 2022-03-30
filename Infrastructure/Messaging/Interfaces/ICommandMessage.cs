namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Command message interface.
    /// </summary>
    public partial interface ICommandMessage : IMessage, ISerializationType, ICorrelationMessage
    {        
    }
}
