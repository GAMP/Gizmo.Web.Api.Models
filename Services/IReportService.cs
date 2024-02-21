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
        /// Generates host usage report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<HostUsageReportModel> HostUsageAsync(HostUsageReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates top users report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<TopUsersReportModel> TopUsersAsync(TopUsersReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates user report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<UserReportModel> UserAsync(UserReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates product report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<ProductReportModel> ProductAsync(ProductReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates products report.
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
        /// Generates transactions log report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<TransactionsLogReportModel> TransactionsLogAsync(TransactionsLogReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates shifts log report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<ShiftsLogReportModel> ShiftsLogAsync(ShiftsLogReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates assets log report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<AssetsLogReportModel> AssetsLogAsync(AssetsLogReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates invoice report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<InvoiceReportModel> InvoiceAsync(InvoiceReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates invoices log report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<InvoicesLogReportModel> InvoicesLogAsync(InvoicesLogReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates zlog report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<ZLogReportModel> ZLogAsync(ZLogReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates z report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<ZReportModel> ZAsync(ZReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates application report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<ApplicationReportModel> ApplicationAsync(ApplicationReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates applications report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<ApplicationsReportModel> ApplicationsAsync(ApplicationsReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates sessions log report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<SessionsLogReportModel> SessionsLogAsync(SessionsLogReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates license report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<LicenseReportModel> LicenseAsync(LicenseReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates licenses report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<LicensesReportModel> LicensesAsync(LicensesReportParametersModel parameters, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates orders log report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<OrdersLogReportModel> OrdersLogAsync(OrdersLogReportParametersModel parameters, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Generates orders statistics report.
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Report.</returns>
        public Task<OrdersStatisticsReportModel> OrdersStatisticsAsync(OrdersStatisticsReportParametersModel parameters, CancellationToken cancellationToken = default);
    }
}
