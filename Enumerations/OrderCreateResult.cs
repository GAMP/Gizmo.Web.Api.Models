namespace Gizmo.Web.Api.Models.Enumerations
{
    /// <summary>
    /// Order create result.
    /// </summary>
    public enum  OrderCreateResult
    {
        /// <summary>
        /// Sucess.
        /// </summary>
        Sucess = 0,

        /// <summary>
        /// Invalid lines.
        /// </summary>
        InvalidLines =1,

        /// <summary>
        /// Invalid user id.
        /// </summary>
        InvalidUserId =2,
    }
}
