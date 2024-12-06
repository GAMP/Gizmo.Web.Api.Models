#nullable enable

using System;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Branch model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class BranchModel : IModelIntIdentifier, IBranchModel
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        [StringLength(45)]
        public string Name { get; init; } = string.Empty;

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public string? BusinessName { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public string? Country { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public string? City { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(5)]
        public string? Address { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(6)]
        public string? Phone { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(7)]
        public string? Email { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(8)]
        public string? PostalCode { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(9)]
        public string? Region { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(10)]
        public string? WebSite { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(11)]
        public string? Info { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(12)]
        [StringLength(45)]
        public string? TimeZone { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(13)]
        public bool HasBusinessSchedule { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(14)]
        public int? BusinessStartWeekDay { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(15)]
        public int? BusinessEndWeekDay { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(16)]
        public string? BusinessDayStart { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(17)]
        public string? BusinessDayEnd { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(18)]
        public bool? IsFiscalizationEnabled { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(19)]
        public string? BusinessVATId { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(20)]
        public TaxSystemCountry? TaxSystem { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(21)]
        public TaxSystems? GoodsTaxSystem { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(22)]
        public TaxSystems? ServicesTaxSystem { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(23)]
        public bool? TreatDepositsAsService { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(24)]
        public string? DepositServiceDescription { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(25)]
        public decimal? TimeBasedServiceVATRate { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(26)]
        public VatRates? DepositVATRate
        {
            get; init;
        }

        /// <inheritdoc/>
        [MessagePack.Key(27)]
        public AdvancePaymentTypes? DepositAdvancePaymentType
        {
            get; init;
        }

        /// <inheritdoc/>
        [MessagePack.Key(28)]
        public int? CompanionId { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(29)]
        public Guid Guid { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(30)]
        public bool IsDisabled { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(31)]
        public DateTime? DisableTime { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(32)]
        public bool IsDeleted { get; set; }        
    }
}
