using Gizmo;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Bundle.
    /// </summary>
    [Serializable]
    [DataContract]
    public class Bundle
    {
        /// <summary>
        /// The stock options of the bundle.
        /// </summary>
        [DataMember]
        public BundleStockOptionType BundleStockOptions
        {
            get; set;
        }
    }
}