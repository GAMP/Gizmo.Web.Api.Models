using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// <inheritdoc cref="IReportModuleResultModel"/>
    /// </summary>
    /// <typeparam name="TReportModel">Report model type.</typeparam>
    /// <typeparam name="TReportModelAdditional">Report model additional model type.</typeparam>
    [MessagePack.MessagePackObject()]
    public sealed class ReportModuleResultModel<TReportModel, TReportModelAdditional> : IReportModuleResultModel
       where TReportModel : class
       where TReportModelAdditional : class
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="reportModel">Report model.</param>
        /// <param name="reportModelAdditional">Report additional model.</param>
        public ReportModuleResultModel(TReportModel reportModel, TReportModelAdditional? reportModelAdditional)
        {
            ReportModel = reportModel;
            ReportModelAdditional = reportModelAdditional;
        }

        /// <inheritdoc cref="IReportModuleResultModel.ReportModel"/>
        [MessagePack.Key(0)]
        public TReportModel ReportModel { get; }

        /// <inheritdoc cref="IReportModuleResultModel.ReportModelAdditional"/>
        [MessagePack.Key(1)]
        public TReportModelAdditional? ReportModelAdditional { get; }

        /// <inheritdoc/>
        [MessagePack.IgnoreMember()]
        [System.Text.Json.Serialization.JsonIgnore()]
        object IReportModuleResultModel.ReportModel => ReportModel;

        /// <inheritdoc/>
        [MessagePack.IgnoreMember()]
        [System.Text.Json.Serialization.JsonIgnore()]
        object? IReportModuleResultModel.ReportModelAdditional => ReportModelAdditional;
    }
}
