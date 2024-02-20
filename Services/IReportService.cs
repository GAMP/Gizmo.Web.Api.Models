using System.Threading;
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

        /// <summary>
        /// Generates hosts report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<HostUsageReportModel> HostUsageAsync(HostsReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates user report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<UsersReportModel> UsersAsync(UsersReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates users report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<UserReportModel> UserAsync(UserReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates user report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<ProductsReportModel> ProductsAsync(ProductsReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates product log report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<ProductsLogReportModel> ProductsLogAsync(ProductsLogReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates stock report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<StockReportModel> StockAsync(StockReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates transactions report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<TransactionsReportModel> TransactionsLogAsync(TransactionReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates shifts report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<ShiftsLogReportModel> ShiftsLogAsync(ShiftsReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates assets report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<AssetsLogReportModel> AssetsLogAsync(AssetsReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates invoices report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<InvoicesLogReportModel> InvoicesLogAsync(InvoicesReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates zlog report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<ZLogReportModel> ZLogAsync(ZLogReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates applications report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<ApplicationsReportModel> ApplicationsAsync(ApplicationsReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates sessions report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<SessionsLogReportModel> SessionsLogAsync(SessionsLogReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates licenses report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<LicensesReportModel> LicensesAsync(LicensesReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates orders report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<OrdersLogReportModel> OrdersLogAsync(OrdersReportParametersModel parameters, CancellationToken cancellationToken = default);
    }
}
