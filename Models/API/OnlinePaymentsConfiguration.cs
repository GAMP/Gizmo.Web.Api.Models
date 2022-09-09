using MessagePack;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Online payments configuration model.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject()]
    public class OnlinePaymentsConfiguration
    {
        #region PROPERTIES

        /// <summary>
        /// The preset amounts.
        /// </summary>
        [DataMember]
        [MessagePack.Key(0)]
        public List<decimal> Presets { get; set; }

        /// <summary>
        /// Indicates whether the user can set custom value.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public bool AllowCustomValue { get; set; }

        /// <summary>
        /// The minimum allowed amount.
        /// </summary>
        [DataMember]
        [MessagePack.Key(2)]
        public decimal MinimumAmount { get; set; }

        #endregion
    }
}