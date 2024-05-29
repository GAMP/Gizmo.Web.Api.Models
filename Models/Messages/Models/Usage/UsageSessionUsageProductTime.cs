﻿namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Usage time fixed.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UsageSessionUsageProductTime : UsageSessionUsage
    {
        /// <summary>
        /// Gets product time purchase id (Invoice line).
        /// </summary>
        [MessagePack.Key(1)]
        public int ProductTimePurchaseId
        {
            get;init;
        }
    }
}
