using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Financial report information about sales or voids for a single group.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class FinancialReportUserGroupInvoicesDTO
    {
        /// <summary>
        /// Group name.
        /// </summary>
        [MessagePack.Key(0)]
        public string Name { get; set; }

        /// <summary>
        /// List of fixed time sold.
        /// </summary>
        [MessagePack.Key(1)]
        public List<SoldProductDTO> FixedTimeProductsSold { get; set; } = new List<SoldProductDTO>();

        /// <summary>
        /// List of session time sold.
        /// </summary>
        [MessagePack.Key(2)]
        public List<SoldProductDTO> SessionTimeProductsSold { get; set; } = new List<SoldProductDTO>();

        /// <summary>
        /// List of time offers sold.
        /// </summary>
        [MessagePack.Key(3)]
        public List<SoldProductDTO> TimeOffersSold { get; set; } = new List<SoldProductDTO>();

        /// <summary>
        /// List of products sold.
        /// </summary>
        [MessagePack.Key(4)]
        public List<SoldProductDTO> ProductsSold { get; set; } = new List<SoldProductDTO>();

        /// <summary>
        /// List of bundles sold.
        /// </summary>
        [MessagePack.Key(5)]
        public List<SoldProductDTO> BundlesSold { get; set; } = new List<SoldProductDTO>();
    }
}
