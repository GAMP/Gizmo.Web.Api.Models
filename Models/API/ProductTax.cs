using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Product tax.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ProductTax : ProductTaxModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the product this tax belongs to.
        /// </summary>
        [DataMember]
        public int ProductId { get; set; }

        #endregion
    }
}