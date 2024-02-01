using System;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    [MessagePack.MessagePackObject()]
    public sealed class OverviewReportParametersModel : IWebApiModel , IUriParametersQuery
    {
        [MessagePack.Key(1)]
        public DateTime? DateFrom { get; set; }

        [MessagePack.Key(2)]
        public DateTime? DateTo { get; set; }

        [MessagePack.Key(3)]
        public int? OperatorId { get; init; }
    }
}
