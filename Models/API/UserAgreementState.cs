using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User agreement state model.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject()]
    public class UserAgreementState
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the user.
        /// </summary>
        [DataMember]
        [MessagePack.Key(0)]
        public int UserId { get; set; }

        /// <summary>
        /// The Id of the user agreement.
        /// </summary>
        [DataMember]
        [MessagePack.Key(1)]
        public int UserAgreementId { get; set; }

        /// <summary>
        /// The user agreement state.
        /// </summary>
        [DataMember]
        [MessagePack.Key(2)]
        public UserAgreementAcceptState AcceptState { get; set; }

        #endregion
    }
}
