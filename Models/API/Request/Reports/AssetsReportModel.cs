using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    [MessagePack.MessagePackObject()]
    public sealed class AssetsReportModel : IWebApiModel
    {
        /// <summary>
        /// Report Name.
        /// </summary>
        [MessagePack.Key(0)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Filtered Date From.
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime DateFrom { get; set; }

        /// <summary>
        /// Filtered Date To.
        /// </summary>
        [MessagePack.Key(2)]
        public DateTime DateTo { get; set; }

        /// <summary>
        /// Company Name.
        /// </summary>
        [MessagePack.Key(3)]
        public string CompanyName { get; set; } = string.Empty;

        ///// <summary>
        ///// Report Type.
        ///// </summary>
        //[Key(4)]
        //public ReportTypes ReportType { get; set; }

        /// <summary>
        /// Filtered Asset Type Id.
        /// </summary>
        [MessagePack.Key(5)]
        public int? AssetTypeId { get; set; }

        /// <summary>
        /// Filtered Asset Type Name.
        /// </summary>
        [MessagePack.Key(6)]
        public string AssetTypeName { get; set; } = string.Empty;

        /// <summary>
        /// Filtered Asset Id.
        /// </summary>
        [MessagePack.Key(7)]
        public int? AssetId { get; set; }

        /// <summary>
        /// Filtered Asset Name.
        /// </summary>
        [MessagePack.Key(8)]
        public string AssetName { get; set; } = string.Empty;

        /// <summary>
        /// Filtered Check Out Operator Id.
        /// </summary>
        [MessagePack.Key(9)]
        public int? CheckOutOperatorId { get; set; }

        /// <summary>
        /// Filtered Check Out Operator Name.
        /// </summary>
        [MessagePack.Key(10)]
        public string CheckOutOperatorName { get; set; } = string.Empty;

        /// <summary>
        /// Filtered Check In Operator Id.
        /// </summary>
        [MessagePack.Key(11)]
        public int? CheckInOperatorId { get; set; }

        /// <summary>
        /// Filtered Check In Operator Name.
        /// </summary>
        [MessagePack.Key(12)]
        public string CheckInOperatorName { get; set; } = string.Empty;

        /// <summary>
        /// Filtered User Id.
        /// </summary>
        [MessagePack.Key(13)]
        public int? UserId { get; set; }

        /// <summary>
        /// Filtered User Name.
        /// </summary>
        [MessagePack.Key(14)]
        public string UserName { get; set; } = string.Empty;

        /// <summary>
        /// List of asset transactions within the reporting period.
        /// </summary>
        [MessagePack.Key(15)]
        public List<AssetTransactionDTOModel> AssetTransactions { get; set; } = new List<AssetTransactionDTOModel>();
    }

    [MessagePack.MessagePackObject()]
    public sealed class AssetsReportParametersModel : IWebApiModel , IUriParametersQuery
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
        /// Filter Asset Type Id.
        /// </summary>
        [MessagePack.Key(2)]
        public int? AssetTypeId { get; set; }

        /// <summary>
        /// Filter Asset Id.
        /// </summary>
        [MessagePack.Key(3)]
        public int? AssetId { get; set; }

        /// <summary>
        /// Filter Check Out Operator Id.
        /// </summary>
        [MessagePack.Key(4)]
        public int? CheckOutOperatorId { get; set; }

        /// <summary>
        /// Filter Check In Operator Id.
        /// </summary>
        [MessagePack.Key(5)]
        public int? CheckInOperatorId { get; set; }

        /// <summary>
        /// Filter User Id.
        /// </summary>
        [MessagePack.Key(6)]
        public int? UserId { get; set; }

        #endregion
    }

    /// <summary>
    /// Asset transaction information.
    /// </summary>
    [MessagePack.MessagePackObject]
    public class AssetTransactionDTOModel
    {
        /// <summary>
        /// Asset type.
        /// </summary>
        [MessagePack.Key(0)]
        public string AssetType { get; set; } = string.Empty;

        /// <summary>
        /// Asset number.
        /// </summary>
        [MessagePack.Key(1)]
        public int AssetNumber { get; set; }

        /// <summary>
        /// Asset name.
        /// </summary>
        [MessagePack.Key(2)]
        public string AssetName { get; set; } = string.Empty;

        /// <summary>
        /// Customer name.
        /// </summary>
        [MessagePack.Key(3)]
        public string Customer { get; set; } = string.Empty;

        /// <summary>
        /// The time the asset was checked out.
        /// </summary>
        [MessagePack.Key(4)]
        public DateTime CheckOutTime { get; set; }

        /// <summary>
        /// Name of the operator that checked out the asset.
        /// </summary>
        [MessagePack.Key(5)]
        public string CheckOutOperator { get; set; } = string.Empty;

        /// <summary>
        /// The time the asset was checked in or null if is still checked out.
        /// </summary>
        [MessagePack.Key(6)]
        public DateTime? CheckInTime { get; set; }

        /// <summary>
        /// Name of the operator that checked in the asset.
        /// </summary>
        [MessagePack.Key(7)]
        public string CheckInOperator { get; set; } = string.Empty;

        /// <summary>
        /// Duration of the lease as text.
        /// </summary>
        [MessagePack.Key(8)]
        public string LeaseDuration { get; set; } = string.Empty;
    }
}
