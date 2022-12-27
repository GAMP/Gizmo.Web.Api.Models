using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;

using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.MonetaryUnit
{
    /// <summary>
    /// Monetary unit.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class MonetaryUnit : MonetaryUnitModelBase, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(100)]
        public int Id { get; set; }

        #endregion
    }
}
