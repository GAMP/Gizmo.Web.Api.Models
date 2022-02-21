using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application executable cd image.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ApplicationExecutableCdImageModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The path of the cd image.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        [MessagePack.Key(0)]
        public string Path { get; set; }

        /// <summary>
        /// The mounting options of the cd image.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        [MessagePack.Key(1)]
        public string MountOptions { get; set; }

        /// <summary>
        /// The device id of the cd image.
        /// </summary>
        [DataMember]
        [StringLength(3)]
        [MessagePack.Key(2)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Whether the cd image will check the mounter process exit code value while mounting.
        /// </summary>
        [DataMember]
        [MessagePack.Key(3)]
        public bool CheckExitCode { get; set; }

        #endregion
    }
}