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
    [Union(0, typeof(UserAgreement))]
    [Union(1, typeof(UserAgreementModelCreate))]
    [Union(2, typeof(UserAgreementModelUpdate))]
    public class UserAgreementModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the user agreement.
        /// </summary>
        [DataMember]
        [Key(0)]
        public string Name { get; set; }

        /// <summary>
        /// The user agreement text.
        /// </summary>
        [DataMember]
        [Key(1)]
        public string Agreement { get; set; }

        /// <summary>
        /// The display order of the user agreement.
        /// </summary>
        [DataMember]
        [Key(2)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Whether the user agreement is enabled.
        /// </summary>
        [DataMember]
        [Key(3)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Whether the user agreement is rejectable.
        /// </summary>
        [DataMember]
        [Key(4)]
        public bool IsRejectable { get; set; }

        /// <summary>
        /// Whether the user agreement should ignore state.
        /// </summary>
        [DataMember]
        [Key(5)]
        public bool IgnoreState { get; set; }

        #endregion
    }
}
