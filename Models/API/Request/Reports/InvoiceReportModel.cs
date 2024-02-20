using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;
using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoice Report.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class InvoiceReportModel : IWebApiModel
    {
        /// <summary>
        /// Filtered Invoice Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int InvoiceId { get; set; }

        /// <summary>
        /// Information of the invoice.
        /// </summary>
        [MessagePack.Key(1)]
        public InvoiceInfoModel Invoice { get; set; }

        /// <summary>
        /// List of products sold with this invoice.
        /// </summary>
        [MessagePack.Key(2)]
        public List<SoldProductDTO> SoldProducts { get; set; } = new List<SoldProductDTO>();

        /// <summary>
        /// List of payments performed for this invoice.
        /// </summary>
        [MessagePack.Key(3)]
        public List<InvoicePaymentDTO> Payments { get; set; } = new List<InvoicePaymentDTO>();

        /// <summary>
        /// List of refunds performed for this invoice.
        /// </summary>
        [MessagePack.Key(4)]
        public List<RefundDTO> Refunds { get; set; } = new List<RefundDTO>();
    }

    /// <summary>
    /// Invoice Report Filter.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class InvoiceReportParametersModel : IWebApiModel, IUriParametersQuery
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
        /// Filter Invoice Id.
        /// </summary>
        [MessagePack.Key(2)]
        [Required]
        public int InvoiceId { get; set; }

        #endregion
    }

    /// <summary>
    /// Sold Product Information.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class SoldProductDTO
    {
        /// <summary>
        /// Product Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// Product name.
        /// </summary>
        [MessagePack.Key(1)]
        public string ProductName { get; set; }

        /// <summary>
        /// The unit price of the product.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// The unit cost of the product.
        /// </summary>
        [MessagePack.Key(3)]
        public decimal UnitCost { get; set; }

        /// <summary>
        /// The number of items sold of the product.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// The total cost of the products.
        /// </summary>
        [MessagePack.Key(5)]
        public decimal TotalCost { get; set; }

        /// <summary>
        /// The cost of the product.
        /// </summary>
        [MessagePack.Key(6)]
        public decimal Value { get; set; }

        /// <summary>
        /// The cost in points of the product.
        /// </summary>
        [MessagePack.Key(7)]
        public int PointsValue { get; set; }

        /// <summary>
        /// The points award of the product.
        /// </summary>
        [MessagePack.Key(8)]
        public int PointsAward { get; set; }

        /// <summary>
        /// The tax rate of the product.
        /// </summary>
        [MessagePack.Key(9)]
        public decimal TaxRate { get; set; }

        /// <summary>
        /// The tax amount of the product.
        /// </summary>
        [MessagePack.Key(10)]
        public decimal Tax { get; set; }

        /// <summary>
        /// The product has been sold as part of a bundle.
        /// </summary>
        [MessagePack.Key(11)]
        public bool IsInBundle { get; set; }
    }

    /// <summary>
    /// Invoice payment information.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class InvoicePaymentDTO// : InvoicesInfoDTO
    {
        /// <summary>
        /// The time that invoice payment was created.
        /// </summary>
        [MessagePack.Key(0)]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// Invoice Id.
        /// </summary>
        [MessagePack.Key(1)]
        public int InvoiceId { get; set; }

        /// <summary>
        /// Payment method Id.
        /// </summary>
        [MessagePack.Key(2)]
        public int PaymentMethodId { get; set; }

        /// <summary>
        /// Payment method name.
        /// </summary>
        [MessagePack.Key(3)]
        public string PaymentMethodName { get; set; }

        /// <summary>
        /// Amount of the invoice payment.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Refunded amount of the invoice payment.
        /// </summary>
        [MessagePack.Key(5)]
        public decimal RefundedAmount { get; set; }

        /// <summary>
        /// Refunded status of the invoice payment.
        /// </summary>
        [MessagePack.Key(6)]
        public RefundStatus RefundStatus { get; set; }

        /// <summary>
        /// Refund method Id of the invoice payment.
        /// </summary>
        [MessagePack.Key(7)]
        public int RefundMethodId { get; set; }

        /// <summary>
        /// The Id of the operator that performed the invoice payment.
        /// </summary>
        [MessagePack.Key(8)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The name of the operator that performed the invoice payment.
        /// </summary>
        [MessagePack.Key(9)]
        public string OperatorName { get; set; }

        /// <summary>
        /// The Id of the register on which the invoice payment was performed.
        /// </summary>
        [MessagePack.Key(10)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// The name of the register on which the invoice payment was performed.
        /// </summary>
        [MessagePack.Key(11)]
        public string RegisterName { get; set; }

        /// <summary>
        /// The Id of the shift that the invoice payment belongs.
        /// </summary>
        [MessagePack.Key(12)]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the user group that the user belongs.
        /// </summary>
        [MessagePack.Key(13)]
        public int UserGroupId { get; set; }

        /// <summary>
        /// The user is guest.
        /// </summary>
        [MessagePack.Key(14)]
        public bool IsGuest { get; set; }

        /// <summary>
        /// Invoice total amount.
        /// </summary>
        [MessagePack.Key(15)]
        public decimal InvoiceTotal { get; set; }

        /// <summary>
        /// Invoice amount outstanding.
        /// </summary>
        [MessagePack.Key(16)]
        public decimal InvoiceOutstanding { get; set; }

        /// <summary>
        /// The invoice is voided.
        /// </summary>
        [MessagePack.Key(17)]
        public bool InvoiceIsVoided { get; set; }

        /// <summary>
        /// The time the invoice related to the order was voided, null if not voided.
        /// </summary>
        [MessagePack.Key(18)]
        public DateTime? VoidCreatedTime { get; set; }

        /// <summary>
        /// The Id of the operator that performed the void.
        /// </summary>
        [MessagePack.Key(19)]
        public int? VoidOperatorId { get; set; }
    }

    /// <summary>
    /// Refund Information.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class RefundDTO
    {
        /// <summary>
        /// The time the refund was created.
        /// </summary>
        [MessagePack.Key(0)]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// The Id of the operator that performed the refund.
        /// </summary>
        [MessagePack.Key(1)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The name of the operator that performed the refund.
        /// </summary>
        [MessagePack.Key(2)]
        public string OperatorName { get; set; }

        /// <summary>
        /// The Id of the register on which the refund performed.
        /// </summary>
        [MessagePack.Key(3)]
        public int? RegisterId { get; set; }

        /// <summary>
        /// The name of the register on which the refund was performed.
        /// </summary>
        [MessagePack.Key(4)]
        public string RegisterName { get; set; }

        /// <summary>
        /// Refund method Id.
        /// </summary>
        [MessagePack.Key(5)]
        public int? RefundMethodId { get; set; }

        /// <summary>
        /// Refund method name.
        /// </summary>
        [MessagePack.Key(6)]
        public string RefundMethodName { get; set; }

        /// <summary>
        /// Amount refunded.
        /// </summary>
        [MessagePack.Key(7)]
        public decimal RefundedAmount { get; set; }

    }
}
