namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Compare string options.
    /// </summary>
    public enum CompareStringOptions
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// String contains pattern.
        /// </summary>
        Contains = 1,

        /// <summary>
        /// The entire string matches pattern.
        /// </summary>
        IsEqualTo = 2,

        /// <summary>
        /// Start of the string matches pattern.
        /// </summary>
        StartsWith = 4,

        /// <summary>
        /// End of the string matches pattern.
        /// </summary>
        EndsWith = 8,

        /// <summary>
        /// String is empty.
        /// </summary>
        IsEmpty = 16,

        /// <summary>
        /// String is not empty.
        /// </summary>
        IsNotEmpty = 32
    }
}
