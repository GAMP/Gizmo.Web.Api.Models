namespace Gizmo.Web.Api.Models.Models.API.Request.Payment
{
    /// <summary>
    /// Order intent creation parameters.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class PaymentIntentOrderCreateParameters : PaymentIntentCreateParametersBase
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets intent order id.
        /// </summary>
        [MessagePack.Key(4)]
        public int OrderId
        {
            get; set;
        }

        #endregion
    }
}
