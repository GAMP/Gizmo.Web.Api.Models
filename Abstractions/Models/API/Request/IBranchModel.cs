using System;

namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Branch.
    /// </summary>
    public interface IBranchModel : IWebApiModel
    {
        /// <summary>
        /// Branch name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Business name.
        /// </summary>
        public string? BusinessName { get; }

        /// <summary>
        /// Country.
        /// </summary>
        public string? Country { get; init; }

        /// <summary>
        /// City.
        /// </summary>
        public string? City { get; }

        /// <summary>
        /// Address.
        /// </summary>
        public string? Address { get; }

        /// <summary>
        /// Phone.
        /// </summary>
        public string? Phone { get; }

        /// <summary>
        /// Email address.
        /// </summary>
        public string? Email { get; }

        /// <summary>
        /// Postal code.
        /// </summary>
        public string? PostalCode { get; }

        /// <summary>
        /// Region.
        /// </summary>
        public string? Region { get; }

        /// <summary>
        /// Web site url.
        /// </summary>
        public string? WebSite { get; }

        /// <summary>
        /// Info.
        /// </summary>
        public string? Info { get; }

        /// <summary>
        /// Branch time zone identifier.
        /// </summary>
        public string? TimeZone { get; }

        /// <summary>
        /// Gets or sets if branch has working schedule.
        /// </summary>
        public bool HasBusinessSchedule { get; }

        /// <summary>
        /// Gets or sets business start week day.
        /// </summary>
        public DayOfWeek? BusinessStartWeekDay { get; }

        /// <summary>
        /// Gets or sets business end week day.
        /// </summary>
        public DayOfWeek? BusinessEndWeekDay { get; }

        /// <summary>
        /// Gets or sets business day start.
        /// </summary>
        public string? BusinessDayStart { get; }

        /// <summary>
        /// Gets or sets business day end.
        /// </summary>
        public string? BusinessDayEnd { get; }

        /// <summary>
        /// Gets if branch is fiscalization enabled.
        /// </summary>
        public bool? IsFiscalizationEnabled { get; }

        /// <summary>
        /// Gets branch VAT id.
        /// </summary>
        public string? BusinessVATID { get; }

        /// <summary>
        /// Gets branch tax system.
        /// </summary>
        public TaxSystemCountry? TaxSystem { get; }

        /// <summary>
        /// Gets branch goods tax system.
        /// </summary>
        public TaxSystems? GoodsTaxSystem { get; }

        /// <summary>
        /// Gets branch services tax system.
        /// </summary>
        public TaxSystems? ServicesTaxSystem { get; }

        /// <summary>
        /// Gets branch deposits tax system.
        /// </summary>
        public TaxSystems? DepositTaxSystem { get; init; }

        /// <summary>
        /// Gets if deposits should be treated as services.
        /// </summary>
        public bool? TreatDepositsAsService { get; }

        /// <summary>
        /// Gets deposit service description.
        /// </summary>
        public string? DepositServiceDescription { get; }

        /// <summary>
        /// Gets time based service VAT rate.
        /// </summary>
        public decimal? TimeBasedServiceVATRate { get; }

        /// <summary>
        /// Gets goods VAT rate.
        /// </summary>
        public VatRates? GoodsVATRate
        {
            get; init;
        }

        /// <summary>
        /// Gets services VAT rate.
        /// </summary>
        public VatRates? ServicesVATRate
        {
            get; init;
        }

        /// <summary>
        /// Gets deposit VAT rate.
        /// </summary>
        public VatRates? DepositVATRate
        {
            get;
        }  

        /// <summary>
        /// Gets branch companion id.
        /// </summary>
        public int? CompanionId { get; }

        /// <summary>
        ///  Gets if branch is deleted.
        /// </summary>
        public bool IsDeleted { get; }
    }
}
