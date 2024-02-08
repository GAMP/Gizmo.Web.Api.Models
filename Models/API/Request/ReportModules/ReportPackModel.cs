﻿using System.Collections.Generic;
using System.Linq;

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
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public TReportModel ReportModel { get; init; } = default!;

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        public TReportAdditionalModel? ReportModelAdditional { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public IEnumerable<ReportModuleFilterMetadataModel> FilterMetadata { get; init; } = Enumerable.Empty<ReportModuleFilterMetadataModel>();

        object IReportPackModel.ReportModel => ReportModel!;

        object? IReportPackModel.ReportModelAdditional => ReportModelAdditional;       
    }
}