using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;

namespace Gizmo.Web.Api.Models.Models.API.Request.Variable.Model
{
    /// <summary>
    /// Variable.
    /// </summary>
    [MessagePackObject]
    public class Variable : VariableModelBase, IApiModelIdentifier
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
