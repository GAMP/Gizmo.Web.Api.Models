using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Time product.
    /// </summary>
    [Serializable]
    [DataContract]
    public class TimeProduct
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets minutes.
        /// </summary>
        [DataMember]
        public int Minutes
        {
            get;
            set;
        }

        /// <summary>
        /// Whether the time product expires at logout.
        /// </summary>
        [DataMember]
        public bool ExpiresAtLogout
        {
            get; set;
        }

        /// <summary>
        /// Whether the time product expires at a specific time in the day.
        /// </summary>
        [DataMember]
        public bool ExpireAtDayTime
        {
            get; set;
        }

        /// <summary>
        /// The minute in the day at which the time product expires.
        /// </summary>
        [DataMember]
        public int ExpireAtDayTimeMinute
        {
            get; set;
        }

        /// <summary>
        /// Whether the time product expires after a specific timespan.
        /// </summary>
        [DataMember]
        public bool ExpireAfterTime
        {
            get; set;
        }

        /// <summary>
        /// The type of timespan after which the time product expires.
        /// </summary>
        [DataMember]
        public ExpireAfterType ExpireAfterType
        {
            get; set;
        }

        /// <summary>
        /// The size of the timespan after which the time product expires.
        /// </summary>
        [DataMember]
        public int ExpiresAfter
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets expire from options.
        /// </summary>
        [DataMember]
        public ExpireFromOptionType ExpiresFrom
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets use order.
        /// </summary>
        [DataMember]
        public int UseOrder
        {
            get; set;
        }

        #endregion
    }
}