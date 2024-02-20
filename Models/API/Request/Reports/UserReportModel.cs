using System.ComponentModel.DataAnnotations;
using System;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    [MessagePack.MessagePackObject()]
    public sealed class UserReportModel : IWebApiModel
    {
    }

    [MessagePack.MessagePackObject()]
    public sealed class UserReportParametersModel : IWebApiModel , IUriParametersQuery
    {
        /// <summary>
        /// Filter Date From.
        /// </summary>
        [MessagePack.Key(0)]
        [Required]
        public DateTime DateFrom { get; set; }

        /// <summary>
        /// Filter Date To.
        /// </summary>
        [MessagePack.Key(1)]
        [Required]
        public DateTime DateTo { get; set; }
    }
}
