namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User member type.
    /// </summary>
    /// <remarks>
    /// Used for polymorphic union.
    /// </remarks>
    public enum UserMemberType
    {
        /// <summary>
        /// Member user.
        /// </summary>
        Member = 0,

        /// <summary>
        /// Guest user.
        /// </summary>
        Guest = 1,
    }
}
