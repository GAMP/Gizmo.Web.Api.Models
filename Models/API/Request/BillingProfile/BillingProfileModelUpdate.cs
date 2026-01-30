using Gizmo.Web.Api.Models.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Billing profile.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class BillingProfileModelUpdate : IBillingProfileModel, IModelIntIdentifier, IUriParametersQuery
    {
        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The name of the billing profile.
        /// </summary>
        [MessagePack.Key(1)]
        [StringLength(255)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The default rate of the billing profile.
        /// </summary>
        [MessagePack.Key(2)]
        public BillingProfileRateModel? DefaultRate { get; set; }
    }
}
