namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Usage time fixed.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UsageSessionUsageProductTime : UsageSessionUsage
    {
        /// <summary>
        /// Gets purchase invoice line id.
        /// </summary>
        [MessagePack.Key(1)]
        public int InvoiceLineId
        {
            get;init;
        }

        /// <summary>
        /// Gets product time id.
        /// </summary>
        [MessagePack.Key(2)]
        public int ProductTimeId
        {
            get;init;
        }
    }
}
