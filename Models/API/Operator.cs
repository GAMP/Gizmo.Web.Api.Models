using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Operator.
    /// </summary>
    [DataContract]
    [Serializable]
    [MessagePackObject]
    public class Operator : OperatorModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// The GUID of the operator.
        /// </summary>
        [DataMember]
        public Guid Guid { get; set; }

        #endregion
    }
}
