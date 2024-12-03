using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Branch update model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class BranchModelUpdate : IModelIntIdentifier, IBranchModel
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        [Required()]
        [StringLength(45, MinimumLength = 1)]
        public string Name { get; init; } = string.Empty;

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public string? Country { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        [StringLength(45)]
        public string? City { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        [StringLength(255)]
        public string? Address { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(5)]
        [StringLength(45)]
        public string? Phone { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(6)]
        [StringLength(255)]
        public string? Email { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(7)]
        [StringLength(45)]
        public string? PostalCode { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(8)]
        [StringLength(45)]
        public string? Region { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(9)]
        [StringLength(255)]
        public string? WebSite { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(10)]
        [StringLength(255)]
        public string? Info { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(11)]
        [StringLength(45)]
        public string? TimeZone { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(12)]
        public bool HasBusinessSchedule { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(13)]
        [Range(0,6)]
        public int? BusinessStartWeekDay { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(14)]
        [Range(0, 6)]
        public int? BusinessEndWeekDay { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(15)]
        public string? BusinessDayStart { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(16)]
        public string? BusinessDayEnd { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(17)]
        public bool? IsFiscalizationEnabled { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(18)]
        public string? BusinessVATId { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(19)]
        public TaxSystemCountry? TaxSystem { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(20)]
        public TaxSystems? GoodsTaxSystem { get; set; }

        /// <inheritdoc/>        
        [MessagePack.Key(21)]
        public TaxSystems? ServicesTaxSystem { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(22)]
        public bool? TreatDepositsAsService { get; set; }

        /// <inheritdoc/>
        [StringLength(255)]
        [MessagePack.Key(23)]
        public string? DepositServiceDescription { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(24)]
        public decimal? TimeBasedServiceVATRate { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(25)]
        public VatRates? DepositVATRate { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(26)]
        public AdvancePaymentTypes? DepositAdvancePaymentType { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(27)]
        public int? CompanionId { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(28)]
        public bool IsDeleted { get; init; }
    }
}
