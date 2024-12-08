namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Recipient model.
    /// </summary>
    [MessagePack.Union(0,typeof(ScheduleReportRecipientUserModel))]
    [MessagePack.MessagePackObject()]
    public abstract class RecipientModel : IWebApiModel
    {
    }
}
