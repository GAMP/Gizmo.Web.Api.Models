using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoice line.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class InvoiceLine : InvoiceLineModelBase, IEntityBase
    {
        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        public int Id { get; set; }
    }
}