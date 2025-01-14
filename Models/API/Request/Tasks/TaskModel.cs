namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Task model.
    /// </summary>
    [MessagePack.Union((int)TaskType.Process,typeof(TaskProcessModel))]
    [MessagePack.Union((int)TaskType.Script, typeof(TaskScriptModel))]
    [MessagePack.Union((int)TaskType.Notification, typeof(TaskNotificationModel))]
    [MessagePack.Union((int)TaskType.Junction, typeof(TaskJunctionModel))]
    public abstract class TaskModel : IWebApiModel
    {
    }
}
