using MessagePack;
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
    [MessagePackObject]
    public class HostLayoutModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The id of the host.
        /// </summary>
        [DataMember]
        [MessagePack.Key(0)]
        public int HostId { get; set; }

        [DataMember]
        [MessagePack.Key(1)]
        public int X { get; set; }

        [DataMember]
        [MessagePack.Key(2)]
        public int Y { get; set; }

        [DataMember]
        [MessagePack.Key(3)]
        public int Height { get; set; }

        [DataMember]
        [MessagePack.Key(4)]
        public int Width { get; set; }

        [DataMember]
        [MessagePack.Key(5)]
        public bool IsHidden { get; set; }

        #endregion
    }
}