﻿using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    [MessagePack.MessagePackObject()]
    public sealed class TransactionsReportModel
    {
    }

    [MessagePack.MessagePackObject()]
    public sealed class TransactionReportParametersModel : IWebApiModel , IUriParametersQuery
    {

    }
}
