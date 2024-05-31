using MessagePack;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment request creation parameters.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class PaymentRequestCreateParametersModel
    {
        #region FIELDS
        private Dictionary<string, string> _metaData = new();
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets requested payment amount.
        /// </summary>
        [MessagePack.Key(0)]
        public decimal Amount { get; init; }

        /// <summary>
        /// Gets payment currency.
        /// </summary>
        [MessagePack.Key(1)]
        public string Currency { get; init; } = "EUR";

        /// <summary>
        /// Gets payment description.
        /// </summary>
        [MessagePack.Key(2)]
        [StringLength(255, MinimumLength = 1)]
        public string Description { get; init; } = null!;

        /// <summary>
        /// Gets cancel url.
        /// </summary>
        [MessagePack.Key(3)]
        [StringLength(2048)]
        public string? CancelUrl { get; init; }

        /// <summary>
        /// Gets success url.
        /// </summary>
        [MessagePack.Key(4)]
        [StringLength(2048)]
        public string? SuccessUrl { get; init; }

        /// <summary>
        /// Gets customer email address.
        /// </summary>
        [MessagePack.Key(5)]
        [StringLength(320)]
        public string? CustomerEmail { get; init; }

        /// <summary>
        /// Indicates that payment request represents an service payment.
        /// </summary>
        [MessagePack.Key(6)]
        public bool IsService
        {
            get; init;
        }

        /// <summary>
        /// Tax system.
        /// </summary>
        [MessagePack.Key(7)]
        public TaxSystems? TaxSystem
        {
            get; init;
        }

        /// <summary>
        /// Gets VAT rate.
        /// </summary>
        [MessagePack.Key(8)]
        public VatRates? VatRate
        {
            get; init;
        }

        /// <summary>
        /// Gets advance payment type.
        /// </summary>
        [MessagePack.Key(9)]
        public AdvancePaymentTypes? AdvancePaymentType
        {
            get; init;
        }

        /// <summary>
        /// Gets business VAT ID number.
        /// </summary>
        [MessagePack.Key(10)]
        public string? BusinessVATNumber
        {
            get; init;
        }

        /// <summary>
        /// Gets seller web address.
        /// </summary>
        [MessagePack.Key(11)]
        public string? BusinessWebSite
        {
            get; init;
        }

        /// <summary>
        /// Gets metadata dictionary.
        /// </summary>
        [MessagePack.Key(12)]
        public Dictionary<string, string> Metadata { get { return _metaData; } set { _metaData = value; } }

        /// <summary>
        /// Indicates if online e-receipt should be created.
        /// </summary>
        /// <remarks>
        /// This option will only have an effect in payment requests where payment provider supports e-receipt.
        /// </remarks>
        [MessagePack.Key(13)]
        public bool OnlineReceipt
        {
            get; init;
        }

        /// <summary>
        /// Gets payment intent.
        /// </summary>
        [JsonIgnore]
        [IgnoreMember]
        public Guid PaymentIntent { get; init; }

        #endregion
    }
}
