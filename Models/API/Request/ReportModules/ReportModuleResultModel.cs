using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// <inheritdoc cref="IReportModuleResultModel"/>
    /// </summary>
    /// <typeparam name="TReportModel"></typeparam>
    /// <typeparam name="TAdditionalModel"></typeparam>
    [MessagePack.MessagePackObject()]
    public sealed class ReportModuleResultModel<TReportModel, TAdditionalModel> : IReportModuleResultModel
       where TReportModel : class
       where TAdditionalModel : class
    {
        /// <summary>
        /// Gets report data.
        /// </summary>
        [MessagePack.Key(0)]
        public TReportModel ReportData { get; init; } = default!;

        /// <summary>
        /// Gets additional report data.
        /// </summary>
        [MessagePack.Key(1)]
        public TAdditionalModel? AdditionalData { get; init; }
    }
}
