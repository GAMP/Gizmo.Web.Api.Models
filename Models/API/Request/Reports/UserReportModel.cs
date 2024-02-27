using System.ComponentModel.DataAnnotations;
using System;
using Gizmo.Web.Api.Models.Abstractions;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User Report.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserReportModel : IWebApiModel
    {
        /// <summary>
        /// User information.
        /// </summary>
        [MessagePack.Key(0)]
        public UserDTOModel User { get; set; } = new UserDTOModel();

        /// <summary>
        /// Points earned.
        /// </summary>
        [MessagePack.Key(1)]
        public int PointsEarned { get; set; }

        /// <summary>
        /// Points used.
        /// </summary>
        [MessagePack.Key(2)]
        public int Redeemed { get; set; }

        /// <summary>
        /// Number of logins.
        /// </summary>
        [MessagePack.Key(3)]
        public int Logins { get; set; }

        /// <summary>
        /// Total session time as text.
        /// </summary>
        [MessagePack.Key(4)]
        public string? LoginTime { get; set; }

        /// <summary>
        /// Total amount of deposits.
        /// </summary>
        [MessagePack.Key(5)]
        public decimal Deposits { get; set; }

        /// <summary>
        /// Total amount of withdrawals.
        /// </summary>
        [MessagePack.Key(6)]
        public decimal Withdrawals { get; set; }

        /// <summary>
        /// Total amount of money spent for products.
        /// </summary>
        [MessagePack.Key(7)]
        public decimal Products { get; set; }

        /// <summary>
        /// Total amount of money spent on fixed time.
        /// </summary>
        [MessagePack.Key(8)]
        public decimal FixedTime { get; set; }

        /// <summary>
        /// Total amount of money spent on session time.
        /// </summary>
        [MessagePack.Key(9)]
        public decimal Sessions { get; set; }

        /// <summary>
        /// Total amount of money spent on time products.
        /// </summary>
        [MessagePack.Key(10)]
        public decimal TimeProducts { get; set; }

        /// <summary>
        /// Total amount of money spent.
        /// </summary>
        [MessagePack.Key(11)]
        public decimal MoneySpend { get; set; }

        /// <summary>
        /// Number of assets checked out.
        /// </summary>
        [MessagePack.Key(12)]
        public int CheckOutItems { get; set; }

        /// <summary>
        /// User's profile picture.
        /// </summary>
        [MessagePack.Key(13)]
        public byte[]? Photo { get; set; }

        /// <summary>
        /// List of records for the average daily session time chart.
        /// </summary>
        [MessagePack.Key(14)]
        public List<ChartRecordDTOModel> SessionTimeChartRecords { get; set; } = new List<ChartRecordDTOModel>();

        /// <summary>
        /// List of records for the average daily spend chart.
        /// </summary>
        [MessagePack.Key(15)]
        public List<ChartRecordDTOModel> InvoicesChartRecords { get; set; } = new List<ChartRecordDTOModel>();
    }

    /// <summary>
    /// User Report Filter.
    /// </summary>
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

        /// <summary>
        /// Filter User Id.
        /// </summary>
        [MessagePack.Key(2)]
        [Required]
        public int UserId { get; set; }
    }
}
