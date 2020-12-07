using System;
using System.Collections.Generic;
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
        #region PROPERTIES

        /// <summary>
        /// The stock options of the bundle.
        /// </summary>
        [DataMember]
        public bool SelfStock { get; set; }

        /// <summary>
        /// The products within the bundle.
        /// </summary>
        [DataMember]
        public IEnumerable<BundledProduct> BundledProducts { get; set; }

        #endregion
    }
}