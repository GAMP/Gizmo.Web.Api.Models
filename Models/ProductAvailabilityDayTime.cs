﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product availability day time.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ProductAvailabilityDayTime
    {
        #region PROPERTIES

        /// <summary>
        /// The start second of this time span.
        /// </summary>
        [DataMember]
        [Required]
        public int StartSecond { get; set; }

        /// <summary>
        /// The end second of this time span.
        /// </summary>
        [DataMember]
        [Required]
        public int EndSecond { get; set; }

        #endregion
    }
}