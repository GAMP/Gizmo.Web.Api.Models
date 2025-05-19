namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// <inheritdoc cref="IReportPackModel"/>
    /// </summary>
    /// <typeparam name="TReportModel">Report model type.</typeparam>
    /// <typeparam name="TReportAdditionalModel">Additional report model type.</typeparam>
    [MessagePack.MessagePackObject()]
    public sealed class ReportPackModel<TReportModel, TReportAdditionalModel> : IReportPackModel
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="reportModel">Report model.</param>
        /// <param name="reportModelAdditional">Additional data.</param>
        public ReportPackModel(TReportModel reportModel, TReportAdditionalModel reportModelAdditional) 
        {
            ReportModel = reportModel;
            ReportModelAdditional = reportModelAdditional;
        }

        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public TReportModel ReportModel { get; init; } = default!;

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public TReportAdditionalModel? ReportModelAdditional { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public ReportModuleExportMetadataModel Metadata { get; init; } = new();

        object IReportPackModel.ReportModel => ReportModel!;

        object? IReportPackModel.ReportModelAdditional => ReportModelAdditional;       
    }
}
