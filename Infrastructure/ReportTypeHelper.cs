using System;
using Gizmo.Web.Api.Models;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api
{
    /// <summary>
    /// Report type helper.
    /// </summary>
    public static class ReportTypeHelper
    {
        /// <summary>
        /// Creates report result type with additional model.
        /// </summary>
        /// <param name="reportType">Report model type.</param>
        /// <param name="additionalType">Report additional model type.</param>
        /// <returns>Result type.</returns>
        public static Type GetReportResultType(Type reportType, Type additionalType)
        {
            var argsType = typeof(ReportModuleResultModel<,>);
            var fullType = argsType.MakeGenericType(reportType, additionalType);
            return fullType;
        }

        /// <summary>
        /// Creates report result type without optional additional model.
        /// </summary>
        /// <param name="reportType">Report model type.</param>
        /// <returns>Result type.</returns>
        public static Type GetReportResultType(Type reportType)
        {
            var argsType = typeof(ReportModuleResultModel<,>);
            var fullType = argsType.MakeGenericType(reportType, typeof(object));
            return fullType;
        }

        /// <summary>
        /// Creates report module result.
        /// </summary>
        /// <param name="model">Report model.</param>
        /// <param name="additionalModel">Additional report model.</param>
        /// <returns>Report module result of type <see cref="ReportModuleResultModel{TReportModel, TReportModelAdditional}"/> </returns>
        public static IReportModuleResultModel CreateReportResult(object model, object? additionalModel = null)
        {
            Type reportResultType = GetReportResultType(model.GetType(), additionalModel == null ? typeof(object) : additionalModel.GetType());
            return (IReportModuleResultModel)Activator.CreateInstance(reportResultType, model, additionalModel);
        }
    }
}
