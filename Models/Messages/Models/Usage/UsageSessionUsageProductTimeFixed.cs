namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Usage time fixed.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UsageSessionUsageProductTimeFixed : UsageSessionUsage
    {
        /// <summary>
        /// Gets purchase invoice line id.
        /// </summary>
        [MessagePack.Key(1)]
        public int InvoiceLineId
        {
            get;init;
        }
    }
}
