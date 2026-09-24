namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Who an action center entry is addressed to.
    /// </summary>
    /// <remarks>
    /// The scope type and its id together name the delivery group. Branch is the common case,
    /// since most of what an operator needs to act on belongs to a place rather than a person.
    /// </remarks>
    public enum ActionCenterScopeType
    {
        /// <summary>
        /// Everyone working at one branch.
        /// </summary>
        Branch = 0,

        /// <summary>
        /// Whoever is at one register.
        /// </summary>
        Register = 1,

        /// <summary>
        /// One operator, on every device they are signed in on.
        /// </summary>
        Operator = 2,

        /// <summary>
        /// Everyone, used when the subject resolves to no branch at all.
        /// </summary>
        /// <remarks>
        /// Appended rather than placed first on purpose, so that a scope left at its default value is
        /// a branch that does not exist and reaches nobody, rather than reaching everybody.
        /// </remarks>
        Global = 3,
    }
}
