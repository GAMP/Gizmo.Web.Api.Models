using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Operator-facing password recovery start request.
    /// </summary>
    [MessagePackObject]
    public sealed class OperatorPasswordRecoveryStartModel : VerificationStartModelBase
    {
        /// <summary>
        /// Target user identifier.
        /// </summary>
        [Key(2)]
        public int UserId { get; set; }
    }
}
