using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;
using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Transactions Log Report.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class TransactionsLogReportModel
    {
        /// <summary>
        /// Filtered Operator Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// Filtered Operator Name.
        /// </summary>
        [MessagePack.Key(1)]
        public string? OperatorName { get; set; }

        /// <summary>
        /// Filtered Register Id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// Filtered Register Name.
        /// </summary>
        [MessagePack.Key(3)]
        public string? RegisterName { get; set; }

        /// <summary>
        /// Filtered User Id.
        /// </summary>
        [MessagePack.Key(4)]
        public int? UserId { get; set; }

        /// <summary>
        /// Filtered User Name.
        /// </summary>
        [MessagePack.Key(5)]
        public string? UserName { get; set; }

        /// <summary>
        /// Filtered Transactions Log Action Type.
        /// </summary>
        [MessagePack.Key(6)]
        public TransactionsLogActionTypes? TransactionsLogActionType { get; set; }

        /// <summary>
        /// List of operator transactions.
        /// </summary>
        [MessagePack.Key(7)]
        public List<OperatorTransactionDTOModel> Transactions { get; set; } = new List<OperatorTransactionDTOModel>();
    }

    /// <summary>
    /// Transactions Log Report Filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class TransactionsLogReportParametersModel : IWebApiModel, IUriParametersQuery
    {
        #region PROPERTIES

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
        /// Filter Operator Id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// Filter Register Id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// Filter User Id.
        /// </summary>
        [MessagePack.Key(4)]
        public int? UserId { get; set; }

        /// <summary>
        /// Filter Void Operator Id.
        /// </summary>
        [MessagePack.Key(5)]
        public int? VoidOperatorId { get; set; }

        /// <summary>
        /// Filter Transactions Log Action Type.
        /// </summary>
        [MessagePack.Key(6)]
        public TransactionsLogActionTypes? TransactionsLogActionType { get; set; }

        #endregion
    }
}
