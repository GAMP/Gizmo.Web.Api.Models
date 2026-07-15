using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Result of starting a verification method.
    /// </summary>
    /// <remarks>
    /// Polymorphic — the concrete type describes the outcome and the action required from the user.
    /// The subtypes form a closed action taxonomy; new delivery mechanisms reuse an existing shape.
    /// </remarks>
    [MessagePack.Union(0, typeof(VerificationStartFailedResult))]
    [MessagePack.Union(1, typeof(CodeInputRequiredResult))]
    [MessagePack.Union(2, typeof(RedirectRequiredResult))]
    [MessagePack.Union(3, typeof(CallRequiredResult))]
    public abstract class VerificationStartResultModelBase : IWebApiModel
    {
    }

    /// <summary>
    /// The verification method could not be started.
    /// </summary>
    [MessagePackObject]
    public sealed class VerificationStartFailedResult : VerificationStartResultModelBase
    {
        /// <summary>
        /// Failure reason.
        /// </summary>
        [Key(0)]
        public VerificationStartResultCode Result { get; set; }
    }

    /// <summary>
    /// A confirmation code is on its way — the user must input it.
    /// </summary>
    /// <remarks>
    /// Covers sms, email, flash call and messenger code delivery; mechanism specific instruction
    /// wording is derived by the client from the capability of the started method.
    /// </remarks>
    [MessagePackObject]
    public sealed class CodeInputRequiredResult : VerificationStartResultModelBase
    {
        /// <summary>
        /// Token value for completing the verification.
        /// </summary>
        [Key(0)]
        public string Token { get; set; } = null!;

        /// <summary>
        /// Confirmation code length.
        /// </summary>
        [Key(1)]
        public int CodeLength { get; set; }

        /// <summary>
        /// Number of seconds before the token expires.
        /// </summary>
        [Key(2)]
        public int ExpiresInSeconds { get; set; }
    }

    /// <summary>
    /// The user must open the redirect url and continue there; completion arrives asynchronously.
    /// </summary>
    [MessagePackObject]
    public sealed class RedirectRequiredResult : VerificationStartResultModelBase
    {
        /// <summary>
        /// Token value for completing the verification.
        /// </summary>
        [Key(0)]
        public string Token { get; set; } = null!;

        /// <summary>
        /// Redirect url for the user to visit.
        /// </summary>
        [Key(1)]
        public string RedirectUrl { get; set; } = null!;

        /// <summary>
        /// Number of seconds before the redirect url and token expire.
        /// </summary>
        [Key(2)]
        public int ExpiresInSeconds { get; set; }
    }

    /// <summary>
    /// The user must call the specified phone number from their phone; completion arrives asynchronously.
    /// </summary>
    [MessagePackObject]
    public sealed class CallRequiredResult : VerificationStartResultModelBase
    {
        /// <summary>
        /// Token value for completing the verification.
        /// </summary>
        [Key(0)]
        public string Token { get; set; } = null!;

        /// <summary>
        /// Phone number the user must call.
        /// </summary>
        [Key(1)]
        public string PhoneNumber { get; set; } = null!;

        /// <summary>
        /// Number of seconds before the token expires.
        /// </summary>
        [Key(2)]
        public int ExpiresInSeconds { get; set; }
    }
}
