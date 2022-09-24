using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User agreement state model.
    /// </summary>
    [Serializable]
    [MessagePackObject()]
    public class UserAgreementState
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the user.
        /// </summary>
        [Key(0)]
        public int UserId { get; set; }

        /// <summary>
        /// The Id of the user agreement.
        /// </summary>
        [Key(1)]
        public int UserAgreementId { get; set; }

        /// <summary>
        /// The user agreement state.
        /// </summary>
        [Key(2)]
        public UserAgreementAcceptState AcceptState { get; set; }

        #endregion
    }
}
