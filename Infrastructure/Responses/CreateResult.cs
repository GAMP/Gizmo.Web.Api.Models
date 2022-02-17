using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Create result.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject()]
    public class CreateResult
    {
        #region PROPERTIES
        
        /// <summary>
        /// The Id of the newly created object.
        /// </summary>
        [DataMember]
        [Key(0)]
        public int Id { get; set; } 

        #endregion
    }
}
