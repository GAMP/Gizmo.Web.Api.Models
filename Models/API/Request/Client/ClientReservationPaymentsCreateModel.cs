namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Client reservation payments create model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ClientReservationPaymentsCreateModel : IWebApiModel
    {
        /// <summary>
        /// Payment method id.
        /// </summary>
        [MessagePack.Key(0)]
        public required int PaymentMethodId { get; init; }
    }
}
