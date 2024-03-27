namespace Gizmo.Web.Api.Models.Enumerations
{
    /// <summary>
    /// Order create result.
    /// </summary>
    public enum  OrderCreateResult
    {
        /// <summary>
        /// Sucess.
        /// </summary>
        Success = 0,

        /// <summary>
        /// Invalid lines.
        /// </summary>
        InvalidLines =1,

        /// <summary>
        /// Invalid user id.
        /// </summary>
        InvalidUserId =2,

        /// <summary>
        /// No guest group.
        /// </summary>
        NoGuestGroup =3,

        /// <summary>
        /// Error.
        /// </summary>
        Error =4,

        /// <summary>
        /// Invalid source host id.
        /// </summary>
        InvalidSourceHostId = 5,
        PaymentExceedsOrderAmount =6,
        InvalidPaymentMethod=7,
        InvalidPaymentAmount =8,
        PartialPaymentNotAllowed =9,
        EmptyOrder =10,
    }
}
