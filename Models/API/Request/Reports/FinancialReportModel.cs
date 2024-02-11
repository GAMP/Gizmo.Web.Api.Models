using Gizmo.Web.Api.Models.Abstractions;
using System;

namespace Gizmo.Web.Api.Models
{
    [MessagePack.MessagePackObject()]
    public sealed class FinancialReportModel : IWebApiModel
    {
    }

    [MessagePack.MessagePackObject()]
    public sealed class FinancialReportParametersModel : IWebApiModel, IUriParametersQuery
    {
        [MessagePack.Key(0)]
        public DateTime? DateFrom { get; set; }

        [MessagePack.Key(1)]
        public DateTime? DateTo { get; set; }

        [MessagePack.Key(2)]
        public int? OperatorId { get; init; }
    }
}
