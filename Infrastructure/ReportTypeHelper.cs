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
        /// <remarks>
        /// <see cref="EmptyReportAdditionalModel"/> type will be used as additional model.<br></br><br></br>
        /// <b>Using non <see cref="EmptyReportAdditionalModel"/> as additional model type in report module will cause serialization errors.</b>
        /// </remarks>
        /// <returns>Result type.</returns>
        public static Type GetReportResultType(Type reportType)
        {
            var argsType = typeof(ReportModuleResultModel<,>);
            var fullType = argsType.MakeGenericType(reportType, typeof(EmptyReportAdditionalModel));
            return fullType;
        }

        /// <summary>
        /// Creates report module result.
        /// </summary>
        /// <param name="reportResultType">Result type.</param>
        /// <param name="model">Report model.</param>
        /// <param name="additionalModel">Additional report model.</param>
        /// <returns>Report module result of type <see cref="ReportModuleResultModel{TReportModel, TReportModelAdditional}"/> </returns>
        public static IReportModuleResultModel CreateReportResult(Type reportResultType, object model, object? additionalModel = null)
        {
            return (IReportModuleResultModel)Activator.CreateInstance(reportResultType, model, additionalModel);
        }

        /// <summary>
        /// Creates report pack model type.
        /// </summary>
        /// <param name="modelType">Model type.</param>
        /// <param name="additionalModelType">Additional model type.</param>
        /// <returns></returns>
        public static Type GetReportPackModelType(Type modelType, Type additionalModelType)
        {
            var argsType = typeof(ReportPackModel<,>);
            var fullType = argsType.MakeGenericType(modelType, additionalModelType);
            return fullType;
        }
    }
}
