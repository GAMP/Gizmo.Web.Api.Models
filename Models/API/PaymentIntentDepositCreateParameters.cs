using System;

namespace Gizmo.Web.Api.Models
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
