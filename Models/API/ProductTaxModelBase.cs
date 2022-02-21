using MessagePack;
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
    [MessagePackObject]
    public class ProductTaxModelBase
    {
        #region PROPERTIES

        [DataMember]
        [MessagePack.Key(0)]
        public int TaxId { get; set; }

        [DataMember]
        [MessagePack.Key(1)]
        public int UseOrder { get; set; }

        [DataMember]
        [MessagePack.Key(2)]
        public bool IsEnabled { get; set; }

        #endregion
    }
}