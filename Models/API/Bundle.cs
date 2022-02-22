using MessagePack;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Bundle.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class Bundle
    {
        #region PROPERTIES

        /// <summary>
        /// The stock options of the bundle.
        /// </summary>
        [DataMember]
        [MessagePack.Key(0)]
        public bool SelfStock { get; set; }

        #endregion
    }
}