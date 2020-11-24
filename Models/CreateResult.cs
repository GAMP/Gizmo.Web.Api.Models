using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Create result.
    /// </summary>
    [Serializable]
    [DataContract]
    public class CreateResult
    {
        /// <summary>
        /// The Id of the newly created object.
        /// </summary>
        [DataMember]
        public int Id { get; set; }
    }
}
