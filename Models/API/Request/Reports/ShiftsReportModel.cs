﻿using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    [MessagePack.MessagePackObject()]
    public sealed class ShiftsReportModel : IWebApiModel
    {
    }

    [MessagePack.MessagePackObject()]
    public sealed class ShiftsReportParametersModel : IWebApiModel , IUriParametersQuery
    {

    }
}