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
        /// Gets or sets weekday maximum minutes.
        /// </summary>
        [DataMember]
        [Range(1, 7200)]
        public int? WeekDayMaxMinutes
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets weekend maximum minutes.
        /// </summary>
        [DataMember]
        [Range(1, 2880)]
        public int? WeekEndMaxMinutes
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets expire after days.
        /// </summary>
        [DataMember]
        public int ExpiresAfter
        {
            get; set;
        }

        /// <summary>
        /// The expiration options of the time product.
        /// </summary>
        [DataMember]
        public ProductTimeExpirationOptionType ExpirationOptions
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets expire from options.
        /// </summary>
        [DataMember]
        public ExpireFromOptionType ExpireFromOptions
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets usage options.
        /// </summary>
        [DataMember]
        public ProductTimeUsageOptionType UsageOptions
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets use order.
        /// </summary>
        [DataMember]
        public int UseOrder
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets expire after type.
        /// </summary>
        [DataMember]
        public ExpireAfterType ExpireAfterType
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets expire at day time minute.
        /// </summary>
        [DataMember]
        public int ExpireAtDayTimeMinute
        {
            get; set;
        }


        /// <summary>
        /// The usage availability of the product.
        /// </summary>
        [DataMember]
        public ProductUsageAvailability ProductUsageAvailability { get; set; }
    }
}