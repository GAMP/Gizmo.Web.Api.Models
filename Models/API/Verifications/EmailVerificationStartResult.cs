using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Email verification start result model.
    /// </summary>
    [ProtoContract()]
    [MessagePack.MessagePackObject()]
    public class EmailVerificationStartResult : VerificationResultBase<VerificationStartResultCode>
    {
        #region PROPERTIES

        /// <summary>
        /// Email being verified.
        /// </summary>
        [ProtoMember(1)]
        [MessagePack.Key(5)]
        public string Email
        {
            get; set;
        }

        #endregion
    }
}
