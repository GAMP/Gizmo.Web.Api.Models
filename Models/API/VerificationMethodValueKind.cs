namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Kind of the value supplied when starting a verification method.
    /// </summary>
    /// <remarks>
    /// States what the caller put in <see cref="VerificationMethodStartModelBase.Value"/>. It never
    /// carries the delivery mechanism or the communication channel — both are resolved server side
    /// from <see cref="VerificationMethodStartModelBase.MethodId"/>.
    /// <para>
    /// Password recovery reads it as the lookup rule. Registration validates the value by the
    /// resolved channel instead and uses this only to reject a request whose value kind contradicts
    /// the selected method.
    /// </para>
    /// </remarks>
    public enum VerificationMethodValueKind
    {
        /// <summary>
        /// No value is supplied. Used by flows that need no user input, e.g. redirect registration.
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
