using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request
{
    /// <summary>
    /// Line fixed time.
    /// </summary>
    [MessagePackObject]
    public sealed class LineFixedTime : IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The quantity type of the fixed time line.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(0)]
        public FixedTimeQuantityType QuantityType { get; set; }

        #endregion
    }
}