namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Instance authorization versions.
    /// </summary>
    public enum InstanceAuthorizationVersion
    {
        /// <summary>
        /// Version 1, the instance is authorized by its hardware id.
        /// </summary>
        V1 = 1,

        /// <summary>
        /// Version 2, the instance is authorized by an installation id that is obtained by binding the instance to a portal instance.
        /// </summary>
        V2 = 2,
    }
}
