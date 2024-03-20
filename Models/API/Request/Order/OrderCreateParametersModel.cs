namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order creation parameters.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OrderCreateParametersModel : IWebApiModel
    {
        /// <summary>
        /// Disable receipt printing.
        /// </summary>
        [MessagePack.Key(0)]
        public bool DisableReceiptPrinting { get; init; }
    }
}
