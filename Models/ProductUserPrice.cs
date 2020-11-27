﻿using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product user price.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ProductUserPrice : ProductUserPriceBase
    {
        #region PROPERTIES

        /// <summary>
        /// The price in points for this user price.
        /// </summary>
        [DataMember]
        public int PointsPrice { get; set; }

        /// <summary>
        /// The purchase options for this user price.
        /// </summary>
        [DataMember]
        public PurchaseOptionType PurchaseOptions { get; set; }

        #endregion
    }
}