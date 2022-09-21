using ProtoBuf;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Account creation by token result model.
    /// </summary>
    [ProtoContract()]
    public class AccountCreationByTokenCompleteResult : VerificationResultBase<AccountCreationByTokenCompleteResultCode>
    {
        #region PROPERTIES

        /// <summary>
        /// Newly created user id.
        /// </summary>
        [ProtoMember(1)]
        public int? CreatedUserId
        {
            get; set;
        }

        #endregion
    }
}
