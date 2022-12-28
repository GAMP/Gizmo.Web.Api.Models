using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Tax
{
    /// <summary>
    /// Tax.
    /// </summary>
    [MessagePackObject]
    public sealed class Tax : ITaxApiModel, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The name of the tax.
        /// </summary>
        [MessagePack.Key(1)]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        /// <summary>
        /// The value of the tax.
        /// </summary>
        [MessagePack.Key(2)]
        [Range(0, 100)]
        public decimal Value { get; set; }

        #endregion
    }
}
