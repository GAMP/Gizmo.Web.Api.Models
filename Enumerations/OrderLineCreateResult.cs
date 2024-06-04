namespace Gizmo.Web.Api.Models.Enumerations
{
    /// <summary>
    /// Order line creation result code.
    /// </summary>
    public enum OrderLineCreateResult
    {
        /// <summary>
        /// Success.
        /// </summary>
        Success = 0,
        /// <summary>
        /// Error validating.
        /// </summary>
        Error = 1,
        /// <summary>
        /// Pay type not allowed.
        /// </summary>
        PayTypeNotAllowed = 2,
        /// <summary>
        /// Price mismatch.
        /// </summary>
        PriceMissMatch = 3,
        /// <summary>
        /// Custom price not allowed.
        /// </summary>
        CustomPriceRestricted = 4,
        /// <summary>
        /// User group not allowed.
        /// </summary>
        UserGroupSaleRestricted = 6,
        /// <summary>
        /// Invalid product id.
        /// </summary>
        InvalidProductId = 7,
        /// <summary>
        /// Guest sale not supported.
        /// </summary>
        /// <remarks>
        /// Examples would be selling a deposit or fixed time to an unknown guest.
        /// </remarks>
        GuestSaleNotSupported = 8,
        /// <summary>
        /// Guest sale restricted.
        /// </summary>
        GuestSaleRestricted = 9,
        /// <summary>
        /// Invalid quantity.
        /// </summary>
        InvalidQuantity = 10,
        /// <summary>
        /// Out of stock.
        /// </summary>
        OutOfStock = 11,
    }
}
