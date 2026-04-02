using System;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Base request for starting a verification operation.
    /// </summary>
    [MessagePackObject]
    public abstract class VerificationStartModelBase
    {
        /// <summary>
        /// Integration instance public identifier.
        /// </summary>
        [Key(0)]
        public Guid IntegrationPublicId { get; set; }

        /// <summary>
        /// Preferred delivery method.
        /// </summary>
        [Key(1)]
        public VerificationDeliveryMethod DeliveryMethod { get; set; }
    }
}
