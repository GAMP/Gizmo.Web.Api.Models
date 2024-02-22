using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Financial report information about sales or voids for a single group.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class FinancialReportUserGroupInvoicesDTOModel
    {
        /// <summary>
        /// Group name.
        /// </summary>
        [MessagePack.Key(0)]
        public string? Name { get; set; }

        /// <summary>
        /// List of fixed time sold.
        /// </summary>
        [MessagePack.Key(1)]
        public List<SoldProductDTOModel> FixedTimeProductsSold { get; set; } = new List<SoldProductDTOModel>();

        /// <summary>
        /// List of session time sold.
        /// </summary>
        [MessagePack.Key(2)]
        public List<SoldProductDTOModel> SessionTimeProductsSold { get; set; } = new List<SoldProductDTOModel>();

        /// <summary>
        /// List of time offers sold.
        /// </summary>
        [MessagePack.Key(3)]
        public List<SoldProductDTOModel> TimeOffersSold { get; set; } = new List<SoldProductDTOModel>();

        /// <summary>
        /// List of products sold.
        /// </summary>
        [MessagePack.Key(4)]
        public List<SoldProductDTOModel> ProductsSold { get; set; } = new List<SoldProductDTOModel>();

        /// <summary>
        /// List of bundles sold.
        /// </summary>
        [MessagePack.Key(5)]
        public List<SoldProductDTOModel> BundlesSold { get; set; } = new List<SoldProductDTOModel>();
    }
}
