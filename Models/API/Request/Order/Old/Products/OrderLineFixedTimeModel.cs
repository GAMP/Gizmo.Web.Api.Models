using Gizmo.Web.Api.Models.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Order line fixed time product.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class OrderLineFixedTimeModel : IUriParametersQuery 
    {
        /// <summary>
        /// The quantity type of the fixed time line.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(0)]
        public FixedTimeQuantityType QuantityType { get; set; }
    }
}
