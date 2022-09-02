namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Base model for payment intent creation.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public abstract class PaymentIntentCreateParametersBase
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets intent user id.
        /// </summary>
        [MessagePack.Key(0)]
        public int UserId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets intent amount.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal Amount
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets payment method id.
        /// </summary>
        /// <remarks>
        /// The method must have payment provider set, otherwise operation will fail.
        /// </remarks>
        [MessagePack.Key(3)]
        public int PaymentMethodId
        {
            get; set;
        }

        #endregion
    }
}
