using System.ComponentModel.DataAnnotations;
using System;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    [MessagePack.MessagePackObject()]
    public sealed class ZReportModel : IWebApiModel
    {
    }

    [MessagePack.MessagePackObject()]
    public sealed class ZReportParametersModel : IWebApiModel, IUriParametersQuery
    {
    }
}
