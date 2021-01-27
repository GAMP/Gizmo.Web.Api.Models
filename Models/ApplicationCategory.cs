using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application category.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationCategory : ApplicationCategoryModelBase, IEntityBase
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// The GUID of the application category.
        /// </summary>
        [DataMember]
        public Guid Guid { get; set; }

        #endregion
    }
}
