using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User agreement model.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject()]
    public class UserAgreement : UserAgreementModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        [MessagePack.Key(100)]
        public int Id { get; set; }

        #endregion
    }
}
