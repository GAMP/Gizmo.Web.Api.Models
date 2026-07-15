using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Base request for starting a verification method.
    /// </summary>
    /// <remarks>
    /// Everything about the mechanism is derived server side from the referenced verification method
    /// entry (integration instance, capability, channel, chain context) — entry identity is immutable,
    /// so the id can never silently change meaning.
    /// </remarks>
    [MessagePackObject]
    public abstract class VerificationMethodStartModelBase
    {
        /// <summary>
        /// Verification method entry id.
        /// </summary>
        [Key(0)]
        public int MethodId { get; set; }

        /// <summary>
        /// Channel specific destination value, where the flow requires one.
        /// Interpreted and validated by the entry's channel (e.g. phone number for the sms channel,
        /// email address for the email channel). Must be omitted in flows that source the destination
        /// from the user record (e.g. password recovery) and for redirect mechanisms.
        /// </summary>
        [Key(1)]
        public string? Value { get; set; }
    }

    /// <summary>
    /// Registration start request.
    /// </summary>
    [MessagePackObject]
    public sealed class RegistrationMethodStartModel : VerificationMethodStartModelBase
    {
    }

    /// <summary>
    /// Password recovery start request.
    /// </summary>
    [MessagePackObject]
    public sealed class PasswordRecoveryMethodStartModel : VerificationMethodStartModelBase
    {
        /// <summary>
        /// Value identifying the account to recover — username, email or mobile phone.
        /// Used to locate the user; the code destination is always sourced from the user record.
        /// </summary>
        [Key(2)]
        public string MatchValue { get; set; } = null!;
    }

    /// <summary>
    /// Phone number verification start request. The number being verified is supplied in
    /// <see cref="VerificationMethodStartModelBase.Value"/>.
    /// </summary>
    [MessagePackObject]
    public sealed class PhoneVerificationMethodStartModel : VerificationMethodStartModelBase
    {
    }

    /// <summary>
    /// Email address verification start request. The address being verified is supplied in
    /// <see cref="VerificationMethodStartModelBase.Value"/>.
    /// </summary>
    [MessagePackObject]
    public sealed class EmailVerificationMethodStartModel : VerificationMethodStartModelBase
    {
    }
}
