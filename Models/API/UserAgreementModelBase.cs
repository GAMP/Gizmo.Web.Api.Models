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
        /// The agreement text.
        /// </summary>
        [DataMember]
        [Key(0)]
        public string Agreement { get; set; }

        /// <summary>
        /// The options of the agreement.
        /// </summary>
        [DataMember]
        [Key(1)]
        public UserAgreementOptions Options { get; set; }

        /// <summary>
        /// The display options of the agreement.
        /// </summary>
        [DataMember]
        [Key(2)]
        public UserAgreementDisplayOptions DisplayOptions { get; set; }

        /// <summary>
        /// The display order of the agreement.
        /// </summary>
        [DataMember]
        [Key(3)]
        public int DisplayOrder { get; set; }

        #endregion
    }
}
