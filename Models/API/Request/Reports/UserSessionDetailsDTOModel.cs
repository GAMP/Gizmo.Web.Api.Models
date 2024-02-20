using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User Session Details.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class UserSessionDetailsDTOModel : UserSessionDTOModel
    {
        /// <summary>
        /// The name of the user to which the session belongs.
        /// </summary>
        [MessagePack.Key(0)]
        public string UserName { get; set; }

        /// <summary>
        /// The name of the host on which the user session ran.
        /// </summary>
        [MessagePack.Key(1)]
        public string HostName { get; set; }

        /// <summary>
        /// The number of the host on which the user session ran.
        /// </summary>
        [MessagePack.Key(2)]
        public int HostNumber { get; set; }

        /// <summary>
        /// The Id of the operator that started the session.
        /// </summary>
        [MessagePack.Key(3)]
        public int? LoginOperatorId { get; set; }

        /// <summary>
        /// The name of the operator that started the session.
        /// </summary>
        [MessagePack.Key(4)]
        public string LoginOperatorName { get; set; }

        /// <summary>
        /// The Id of the operator that ended the session.
        /// </summary>
        [MessagePack.Key(5)]
        public int? LogoutOperatorId { get; set; }

        /// <summary>
        /// The name of the operator that ended the session.
        /// </summary>
        [MessagePack.Key(6)]
        public string LogoutOperatorName { get; set; }

        /// <summary>
        /// The name of the host to which the session was moved.
        /// </summary>
        [MessagePack.Key(7)]
        public string MoveHostName { get; set; }

        /// <summary>
        /// The state of the session.
        /// </summary>
        [MessagePack.Key(8)]
        public SessionState State { get; set; }
    }
}
