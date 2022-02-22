using MessagePack;
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
    [MessagePackObject]
    public class User : UserModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        [MessagePack.Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The GUID of the user.
        /// </summary>
        [DataMember]
        [MessagePack.Key(101)]
        public Guid Guid { get; set; }

        /// <summary>
        /// Whether the user is guest.
        /// </summary>
        [DataMember]
        [MessagePack.Key(102)]
        public bool IsGuest { get; set; }

        #endregion
    }
}
