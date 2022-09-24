using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for payment methods.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class PaymentMethodsFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// Return payment methods with names that contain the specified string.
        /// </summary>
        [Key(200)]
        public string Name { get; set; }

        /// <summary>
        /// Return deleted payment methods.
        /// </summary>
        [Key(201)]
        public bool? IsDeleted { get; set; }

        #endregion
    }
}
