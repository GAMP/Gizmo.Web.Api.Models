using MessagePack;
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
    [MessagePackObject]
    public class TimeProduct
    {
        #region PROPERTIES

        /// <summary>
        /// The number of minutes of the time product.
        /// </summary>
        [DataMember]
        [MessagePack.Key(0)]
        public int Minutes
        {
            get;
            set;
        }

        /// <summary>
        /// Whether the time product expires at logout.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public bool ExpiresAtLogout
        {
            get; set;
        }

        /// <summary>
        /// Whether the time product expires at a specific time in the day.
        /// </summary>
        [DataMember]
        [MessagePack.Key(2)]
        public bool ExpireAtDayTime
        {
            get; set;
        }

        /// <summary>
        /// The minute in the day at which the time product expires.
        /// </summary>
        [DataMember]
        [MessagePack.Key(3)]
        public int ExpireAtDayTimeMinute
        {
            get; set;
        }

        /// <summary>
        /// Whether the time product expires after a specific timespan.
        /// </summary>
        [DataMember]
        [MessagePack.Key(4)]
        public bool ExpireAfterTime
        {
            get; set;
        }

        /// <summary>
        /// The type of timespan after which the time product expires.
        /// </summary>
        [DataMember]
        [EnumValue]
        [MessagePack.Key(5)]
        public ExpireAfterType ExpireAfterType
        {
            get; set;
        }

        /// <summary>
        /// The size of the timespan after which the time product expires.
        /// </summary>
        [DataMember]
        [MessagePack.Key(6)]
        public int ExpiresAfter
        {
            get; set;
        }

        /// <summary>
        /// The expire from options of the product.
        /// </summary>
        [DataMember]
        [EnumValue]
        [MessagePack.Key(7)]
        public ExpireFromOptionType ExpiresFrom
        {
            get; set;
        }

        /// <summary>
        /// The order in which the product is used.
        /// </summary>
        [DataMember]
        [MessagePack.Key(8)]
        public int UseOrder
        {
            get; set;
        }

        #endregion
    }
}