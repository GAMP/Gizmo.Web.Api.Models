using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Payment.Method
{
    /// <summary>
    /// Payment method.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class PaymentMethodModelUpdate : PaymentMethodModelBase, IApiModelIdentifier, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Required]
        [MessagePack.Key(100)]
        public int Id { get; set; }

        #endregion
    }
}