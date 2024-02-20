﻿using System.ComponentModel.DataAnnotations;
using System;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Licenses Report.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class LicensesReportModel : IWebApiModel
    {
    }

    /// <summary>
    /// Licenses Report Filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class LicensesReportParametersModel : IWebApiModel , IUriParametersQuery
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

        /// <summary>
        /// Filter Application Id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? ApplicationId { get; set; }

        /// <summary>
        /// Hide unused licenses.
        /// </summary>
        [MessagePack.Key(3)]
        public bool HideUnused { get; set; }
    }
}
