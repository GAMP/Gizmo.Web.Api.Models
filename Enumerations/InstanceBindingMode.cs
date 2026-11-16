namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Instance binding modes.
    /// </summary>
    public enum InstanceBindingMode
    {
        /// <summary>
        /// Binding is not supported by the current instance authorization version.
        /// </summary>
        NotSupported = 0,

        /// <summary>
        /// The instance is not bound to a portal instance.
        /// </summary>
        NotBound = 1,

        /// <summary>
        /// The instance is bound to a portal instance.
        /// </summary>
        Bound = 2,
    }
}
