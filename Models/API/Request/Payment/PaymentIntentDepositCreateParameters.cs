using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Payment
{
    /// <summary>
    /// Deposit payment intent creation parameters.
    /// </summary>
    [Serializable]
    [MessagePack.MessagePackObject()]
    public class PaymentIntentDepositCreateParameters : PaymentIntentCreateParametersBase
    {
    }
}
