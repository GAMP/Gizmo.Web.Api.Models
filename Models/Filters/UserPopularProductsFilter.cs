using System;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for user popular products.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserPopularProductsFilter
    {
        #region FIELDS

        private const int DefaultLimit = 10;
        private int _limit = DefaultLimit;

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Limit records for the response.
        ///  equal 0 => DefaultLimit;
        ///  equal -1 => int.MaxValue;
        ///  less then -1 => DefaultLimit;
        ///  Default limit is 10.
        /// </summary>
        [Key(0)]
        public int Limit
        {
            get
            {
                return _limit;
            }
            set
            {
                _limit = value switch
                {
                    0 => DefaultLimit,
                    -1 => int.MaxValue - 1,
                    < -1 => DefaultLimit,
                    _ => value - 1
                };
            }
        }

        /// <summary>
        /// Return popular products since the specified date.
        /// </summary>
        [Key(1)]
        public DateTime? DateFrom { get; set; }

        #endregion
    }
}
