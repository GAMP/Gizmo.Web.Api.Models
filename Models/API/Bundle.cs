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
    public class Bundle
    {
        #region PROPERTIES

        /// <summary>
        /// The stock options of the bundle.
        /// </summary>
        [DataMember]
        public bool SelfStock { get; set; }

        #endregion
    }
}