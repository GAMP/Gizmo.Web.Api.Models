using System.ComponentModel.DataAnnotations;

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Ban reason.
    /// </summary>
    [MessagePackObject]
    public sealed class BanReasonModelCreate : IBanReasonModel, IUriParametersQuery
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the ban reason.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(0)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The description of the ban reason.
        /// </summary>
        [MessagePack.Key(1)]
        public string Description { get; set; } = null!;

        /// <summary>
        /// Use order of the ban reason.
        /// </summary>
        [MessagePack.Key(5)]
        public int UseOrder { get; set; }

        #endregion
    }
}
