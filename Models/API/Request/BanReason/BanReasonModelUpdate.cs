using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Ban reason.
    /// </summary>
    [MessagePackObject]
    public sealed class BanReasonModelUpdate : IBanReasonModel, IModelIntIdentifier, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The name of the ban reason.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(1)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The description of the ban reason.
        /// </summary>
        [MessagePack.Key(2)]
        public string Description { get; set; } = null!;

        /// <summary>
        /// Use order of the ban reason.
        /// </summary>
        [MessagePack.Key(3)]
        public int UseOrder { get; set; }

        #endregion
    }
}
