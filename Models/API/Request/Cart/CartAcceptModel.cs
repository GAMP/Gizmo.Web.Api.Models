namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Cart accept model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class CartAcceptModel : IWebApiModel
    {
        /// <summary>
        /// Indicates that invoice should be created.
        /// </summary>
        [MessagePack.Key(0)]
        public bool Invoice { get; init; }

        /// <summary>
        /// Order host id.
        /// </summary>
        /// <remarks>
        /// If set overrides any host id specified and tries to obtain users currently logged in host.
        /// </remarks>
        [MessagePack.Key(1)]
        public int? HostId { get; init; }

        /// <summary>
        /// Disable receipt printing.
        /// </summary>
        [MessagePack.Key(2)]
        public bool DisableReceiptPrinting { get; init; }

        /// <summary>
        /// Enables auto completion.
        /// </summary>
        /// <remarks>
        /// This will only have effect if <see cref="Invoice"/> is equal to true and order source being POS.<br></br> 
        /// In case no invoice created for the order the order cannot transition to completed state.
        /// </remarks>
        [MessagePack.Key(3)]
        public bool AutoComplete { get; init; }
    }
}
