namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Empty additional report data model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class EmptyReportAdditionalModel : IWebApiModel
    {
        /// <summary>
        /// Static instance.
        /// </summary>
        public static readonly EmptyReportAdditionalModel Instance = new();
    }
}
