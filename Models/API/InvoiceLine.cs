using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Invoice line.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class InvoiceLine : InvoiceLineModelBase, IEntityBase
    {
        #region PROPERTIES
        
        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(100)]
        public int Id { get; set; } 

        #endregion
    }
}