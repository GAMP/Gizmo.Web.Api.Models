using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host layout.
    /// </summary>
    [Serializable]
    [DataContract]
    public class HostLayoutModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The id of the host.
        /// </summary>
        [DataMember]
        public int HostId { get; set; }

        [DataMember]
        public int X { get; set; }

        [DataMember]
        public int Y { get; set; }

        [DataMember]
        public int Height { get; set; }

        [DataMember]
        public int Width { get; set; }

        [DataMember]
        public bool IsHidden { get; set; }

        #endregion
    }
}