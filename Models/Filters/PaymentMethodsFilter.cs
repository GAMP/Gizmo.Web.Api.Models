using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filters that can be applied when searching for payment methods.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class PaymentMethodsFilter : PaginationFilter, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// Return payment methods with names that contain the specified string.
        /// </summary>
        [MessagePack.Key(200)]
        public string Name { get; set; }

        /// <summary>
        /// Return deleted payment methods.
        /// </summary>
        [DataMember]
        [MessagePack.Key(201)]
        public bool? IsDeleted { get; set; }

        #endregion
    }
}
