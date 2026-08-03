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
        /// Flow specific value, where the flow requires one.
        /// The concrete request type defines its meaning: destination for registration/verification,
        /// account identifier for user-facing password recovery, or omitted for flows that do not need it.
        /// </summary>
        [Key(1)]
        public string? Value { get; set; }
    }

    /// <summary>
    /// Registration start request.
    /// </summary>
    [MessagePackObject]
    [Union(0, typeof(RegistrationByMobilePhoneMethodStartModel))]
    [Union(1, typeof(RegistrationByEmailMethodStartModel))]
    [Union(2, typeof(RegistrationByRedirectMethodStartModel))]
    public abstract class RegistrationMethodStartModel : VerificationMethodStartModelBase
    {
    }

    /// <summary>
    /// Registration start request by mobile phone.
    /// </summary>
    [MessagePackObject]
    public sealed class RegistrationByMobilePhoneMethodStartModel : RegistrationMethodStartModel
    {
    }

    /// <summary>
    /// Registration start request by email.
    /// </summary>
    [MessagePackObject]
    public sealed class RegistrationByEmailMethodStartModel : RegistrationMethodStartModel
    {
    }

    /// <summary>
    /// Registration start request by redirect.
    /// </summary>
    [MessagePackObject]
    public sealed class RegistrationByRedirectMethodStartModel : RegistrationMethodStartModel
    {
    }

    /// <summary>
    /// Password recovery start request.
    /// </summary>
    [MessagePackObject]
    [Union(0, typeof(PasswordRecoveryByUsernameMethodStartModel))]
    [Union(1, typeof(PasswordRecoveryByEmailMethodStartModel))]
    [Union(2, typeof(PasswordRecoveryByMobilePhoneMethodStartModel))]
    public abstract class PasswordRecoveryMethodStartModel : VerificationMethodStartModelBase
    {
    }

    /// <summary>
    /// Password recovery start request by username.
    /// </summary>
    [MessagePackObject]
    public sealed class PasswordRecoveryByUsernameMethodStartModel : PasswordRecoveryMethodStartModel
    {
    }

    /// <summary>
    /// Password recovery start request by email.
    /// </summary>
    [MessagePackObject]
    public sealed class PasswordRecoveryByEmailMethodStartModel : PasswordRecoveryMethodStartModel
    {
    }

    /// <summary>
    /// Password recovery start request by mobile phone.
    /// </summary>
    [MessagePackObject]
    public sealed class PasswordRecoveryByMobilePhoneMethodStartModel : PasswordRecoveryMethodStartModel
    {
    }

    /// <summary>
    /// Operator-facing password recovery start request.
    /// </summary>
    [MessagePackObject]
    public sealed class OperatorPasswordRecoveryMethodStartModel : VerificationMethodStartModelBase
    {
        /// <summary>
        /// User id of the account to recover.
        /// </summary>
        [Key(2)]
        public int UserId { get; set; }
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
