﻿using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for payment methods.
    /// </summary>
    [Serializable]
    [DataContract]
    public class PaymentMethodsFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// Return deleted payment methods.
        /// </summary>
        [DataMember]
        public bool? IsDeleted { get; set; }

        #endregion
    }
}
