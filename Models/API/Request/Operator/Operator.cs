using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Operator
{
    /// <summary>
    /// Operator.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class Operator : OperatorModelBase, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The GUID of the operator.
        /// </summary>
        [Key(101)]
        public Guid Guid { get; set; }

        #endregion
    }
}
