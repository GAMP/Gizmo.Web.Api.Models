﻿using System.Threading;
using System.Threading.Tasks;
using Gizmo.Web.Api.Models;

namespace Gizmo.Web.Api.Services
{
    /// <summary>
    /// Report generation servcice.
    /// </summary>
    /// <remarks>
    /// This service will have two implementations.<br></br><br></br>
    /// 1) Gizmo server side, the service will call the database directly to generate a report.<br></br>
    /// 2) Gizmo web manager side, the service will use web api to obtain reports, esentially web api endpoints will be calling into same server side implementation.<br></br><br></br>
    /// <b>The service interface is located in web api models library due to exposure to web report models.</b>
    /// </remarks>
    public interface IReportService
    {
        /// <summary>
        /// Generates overview report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<OverviewReportModel> OverviewAsync(OverviewReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates financial report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<FinancialReportModel> FinancialAsync(FinancialReportParametersModel parameters, CancellationToken cancellationToken = default);
    }
}
