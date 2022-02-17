using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product tax.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ProductTaxModelBase
    {
        #region PROPERTIES

        [DataMember]
        public int TaxId { get; set; }

        [DataMember]
        public int UseOrder { get; set; }

        [DataMember]
        public bool IsEnabled { get; set; }

        #endregion
    }
}