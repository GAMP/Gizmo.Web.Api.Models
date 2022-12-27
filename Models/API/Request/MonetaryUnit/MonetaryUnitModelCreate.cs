using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.MonetaryUnit
{
    /// <summary>
    /// Monetary unit.
    /// </summary>
    [MessagePackObject]
    public sealed class MonetaryUnitModelCreate : IMonetaryUnitApiModel, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the monetary unit.
        /// </summary>
        [MessagePack.Key(0)]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        /// <summary>
        /// The value of the monetary unit.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal Value { get; set; }

        /// <summary>
        /// The display order of the monetary unit.
        /// </summary>
        [MessagePack.Key(2)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Whether the monetary unit is deleted.
        /// </summary>
        [MessagePack.Key(3)]
        public bool IsDeleted { get; set; }

        #endregion
    }
}
