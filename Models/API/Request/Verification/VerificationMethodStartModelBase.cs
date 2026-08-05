using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Request for starting a verification method.
    /// </summary>
    /// <remarks>
    /// Everything about the mechanism is derived server side from the referenced verification method
    /// entry (integration instance, capability, channel, chain context) — entry identity is immutable,
    /// so the id can never silently change meaning.
    /// </remarks>
    [MessagePackObject]
    public class VerificationMethodStartModelBase
    {
        /// <summary>
        /// Verification method entry id.
        /// </summary>
        [Key(0)]
        public int MethodId { get; set; }

        /// <summary>
        /// Flow specific value, where the flow requires one — a destination address or an account
        /// identifier. <see cref="ValueKind"/> states which of the two the caller is sending.
        /// </summary>
        [Key(1)]
        public string? Value { get; set; }

        /// <summary>
        /// What <see cref="Value"/> holds.
        /// </summary>
        /// <remarks>
        /// Password recovery is driven by this: it selects how the account is looked up and which
        /// channel the offered methods are narrowed to. Nothing else in the request carries that.
        /// <para>
        /// Registration does not read it to interpret <see cref="Value"/> — the channel of the
        /// selected method does that. Here it only cross checks that the two agree, which catches a
        /// destination sent to a redirect mechanism, where the value would otherwise be dropped in
        /// silence and the user would wait for a code that was never sent.
        /// </para>
        /// </remarks>
        [Key(2)]
        public VerificationMethodValueKind ValueKind { get; set; }
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
    public sealed class EmailVerificationMethodStartModel
        : VerificationMethodStartModelBase
    {
    }
}
