namespace Gizmo.Web.Api.Models.Enumerations
{
    /// <summary>
    /// Order line validation result code.
    /// </summary>
    public enum OrderLineValidateResult
    {
        /// <summary>
        /// Success.
        /// </summary>
        Success = 0,
        /// <summary>
        /// Pay type not allowed.
        /// </summary>
        PayTypeNotAllowed = 1,
        /// <summary>
        /// Price missmatch.
        /// </summary>
        PriceMissMatch = 2,
        /// <summary>
        /// Custom price not allowed.
        /// </summary>
        CustomPriceNotAllowed = 3,
        /// <summary>
        /// User group not allowed.
        /// </summary>
        UserGroupNotAllowed = 4,
        /// <summary>
        /// Invalid product id.
        /// </summary>
        InvalidProductId = 5,
        /// <summary>
        /// Invalid user type.
        /// </summary>
        InvalidUserType =6,
        /// <summary>
        /// Guest sale restricted.
        /// </summary>
        GuestRestricted =7,
        /// <summary>
        /// Error validating.
        /// </summary>
        Error=8,
        InvalidQuantity =9,
    }
}
