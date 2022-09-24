using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Account creation by token result model.
    /// </summary>
    [MessagePackObject()]
    public class AccountCreationByTokenCompleteResult : VerificationResultBase<AccountCreationByTokenCompleteResultCode>
    {
        #region PROPERTIES

        /// <summary>
        /// Newly created user id.
        /// </summary>
        [Key(5)]
        public int? CreatedUserId
        {
            get; set;
        }

        #endregion
    }
}
