namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Recipient model.
    /// </summary>
    [MessagePack.Union(0,typeof(ScheduleReportRecipientModel))]
    [MessagePack.MessagePackObject()]
    public abstract class RecipientModel : IWebApiModel
    {
    }
}
