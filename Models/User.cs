using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User.
    /// </summary>
    [DataContract]
    [Serializable]
    public class User : UserModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// The GUID of the user.
        /// </summary>
        [DataMember]
        public Guid Guid { get; set; }

        #endregion
    }
}
