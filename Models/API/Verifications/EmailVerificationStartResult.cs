using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Email verification start result model.
    /// </summary>
    [MessagePackObject()]
    public class EmailVerificationStartResult : VerificationResultBase<VerificationStartResultCode>
    {
        #region PROPERTIES

        /// <summary>
        /// Email being verified.
        /// </summary>
        [Key(5)]
        public string Email
        {
            get; set;
        }

        #endregion
    }
}
