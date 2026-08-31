namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Kind of the value supplied when starting a verification method.
    /// </summary>
    /// <remarks>
    /// States what the caller put in <see cref="GetRecoveryMethodsModel.Value"/> or
    /// <see cref="UserPasswordRecoveryMethodStartModel.Value"/>. It never carries the delivery
    /// mechanism or the communication channel; those are resolved server side from the selected
    /// verification method.
    /// </remarks>
    public enum VerificationMethodValueKind
    {
        /// <summary>
        /// No value kind is supplied. Not valid for user-facing password recovery lookup or start.
        /// </summary>
        None = 0,

        /// <summary>
        /// The value is a mobile phone number.
        /// </summary>
        MobilePhone = 1,

        /// <summary>
        /// The value is an email address.
        /// </summary>
        Email = 2,

        /// <summary>
        /// The value is a username. Account lookup only — the destination is sourced from the
        /// matched user record. Password recovery only; registration rejects it.
        /// </summary>
        Username = 3,
    }
}
